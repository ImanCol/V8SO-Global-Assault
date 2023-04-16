using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000002 RID: 2
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	public class Bloom : PostEffectsBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public override bool CheckResources()
		{
			base.CheckSupport(false);
			this.screenBlend = base.CheckShaderAndCreateMaterial(this.screenBlendShader, this.screenBlend);
			this.lensFlareMaterial = base.CheckShaderAndCreateMaterial(this.lensFlareShader, this.lensFlareMaterial);
			this.blurAndFlaresMaterial = base.CheckShaderAndCreateMaterial(this.blurAndFlaresShader, this.blurAndFlaresMaterial);
			this.brightPassFilterMaterial = base.CheckShaderAndCreateMaterial(this.brightPassFilterShader, this.brightPassFilterMaterial);
			if (!this.isSupported)
			{
				base.ReportAutoDisable();
			}
			return this.isSupported;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020DC File Offset: 0x000002DC
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			this.doHdr = false;
			if (this.hdr == Bloom.HDRBloomMode.Auto)
			{
				this.doHdr = source.format == RenderTextureFormat.ARGBHalf && base.GetComponent<Camera>().allowHDR;
			}
			else
			{
				this.doHdr = this.hdr == Bloom.HDRBloomMode.On;
			}
			this.doHdr = this.doHdr && this.supportHDRTextures;
			Bloom.BloomScreenBlendMode bloomScreenBlendMode = this.screenBlendMode;
			if (this.doHdr)
			{
				bloomScreenBlendMode = Bloom.BloomScreenBlendMode.Add;
			}
			RenderTextureFormat renderTextureFormat = (this.doHdr ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Default);
			int num = source.width / 2;
			int num2 = source.height / 2;
			int num3 = source.width / 4;
			int num4 = source.height / 4;
			float num5 = 1f * (float)source.width / (1f * (float)source.height);
			float num6 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(num3, num4, 0, renderTextureFormat);
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, num2, 0, renderTextureFormat);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.Blit(source, temporary2, this.screenBlend, 2);
				RenderTexture temporary3 = RenderTexture.GetTemporary(num3, num4, 0, renderTextureFormat);
				Graphics.Blit(temporary2, temporary3, this.screenBlend, 2);
				Graphics.Blit(temporary3, temporary, this.screenBlend, 6);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(source, temporary2);
				Graphics.Blit(temporary2, temporary, this.screenBlend, 6);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(num3, num4, 0, renderTextureFormat);
			this.BrightFilter(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			else if (this.bloomBlurIterations > 10)
			{
				this.bloomBlurIterations = 10;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num7 = (1f + (float)i * 0.25f) * this.sepBlurSpread;
				RenderTexture renderTexture2 = RenderTexture.GetTemporary(num3, num4, 0, renderTextureFormat);
				this.blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, num7 * num6, 0f, 0f));
				Graphics.Blit(renderTexture, renderTexture2, this.blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = renderTexture2;
				renderTexture2 = RenderTexture.GetTemporary(num3, num4, 0, renderTextureFormat);
				this.blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num7 / num5 * num6, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, renderTexture2, this.blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = renderTexture2;
				if (this.quality > Bloom.BloomQuality.Cheap)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.screenBlend, 10);
					}
				}
			}
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(temporary, renderTexture, this.screenBlend, 6);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary4 = RenderTexture.GetTemporary(num3, num4, 0, renderTextureFormat);
				if (this.lensflareMode == Bloom.LensFlareStyle.Ghosting)
				{
					this.BrightFilter(this.lensflareThreshold, renderTexture, temporary4);
					if (this.quality > Bloom.BloomQuality.Cheap)
					{
						this.blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f / (1f * (float)temporary.height), 0f, 0f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(temporary4, temporary, this.blurAndFlaresMaterial, 4);
						this.blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(1.5f / (1f * (float)temporary.width), 0f, 0f, 0f));
						Graphics.SetRenderTarget(temporary4);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(temporary, temporary4, this.blurAndFlaresMaterial, 4);
					}
					this.Vignette(0.975f, temporary4, temporary4);
					this.BlendFlares(temporary4, renderTexture);
				}
				else
				{
					float num8 = 1f * Mathf.Cos(this.flareRotation);
					float num9 = 1f * Mathf.Sin(this.flareRotation);
					float num10 = this.hollyStretchWidth * 1f / num5 * num6;
					this.blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num8, num9, 0f, 0f));
					this.blurAndFlaresMaterial.SetVector("_Threshhold", new Vector4(this.lensflareThreshold, 1f, 0f, 0f));
					this.blurAndFlaresMaterial.SetVector("_TintColor", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.blurAndFlaresMaterial.SetFloat("_Saturation", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary4, temporary, this.blurAndFlaresMaterial, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary, temporary4, this.blurAndFlaresMaterial, 3);
					this.blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num8 * num10, num9 * num10, 0f, 0f));
					this.blurAndFlaresMaterial.SetFloat("_StretchWidth", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary4, temporary, this.blurAndFlaresMaterial, 1);
					this.blurAndFlaresMaterial.SetFloat("_StretchWidth", this.hollyStretchWidth * 2f);
					temporary4.DiscardContents();
					Graphics.Blit(temporary, temporary4, this.blurAndFlaresMaterial, 1);
					this.blurAndFlaresMaterial.SetFloat("_StretchWidth", this.hollyStretchWidth * 4f);
					temporary.DiscardContents();
					Graphics.Blit(temporary4, temporary, this.blurAndFlaresMaterial, 1);
					for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
					{
						num10 = this.hollyStretchWidth * 2f / num5 * num6;
						this.blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num10 * num8, num10 * num9, 0f, 0f));
						temporary4.DiscardContents();
						Graphics.Blit(temporary, temporary4, this.blurAndFlaresMaterial, 4);
						this.blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num10 * num8, num10 * num9, 0f, 0f));
						temporary.DiscardContents();
						Graphics.Blit(temporary4, temporary, this.blurAndFlaresMaterial, 4);
					}
					if (this.lensflareMode == Bloom.LensFlareStyle.Anamorphic)
					{
						this.AddTo(1f, temporary, renderTexture);
					}
					else
					{
						this.Vignette(1f, temporary, temporary4);
						this.BlendFlares(temporary4, temporary);
						this.AddTo(1f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary4);
			}
			int num11 = (int)bloomScreenBlendMode;
			this.screenBlend.SetFloat("_Intensity", this.bloomIntensity);
			this.screenBlend.SetTexture("_ColorBuffer", source);
			if (this.quality > Bloom.BloomQuality.Cheap)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(num, num2, 0, renderTextureFormat);
				Graphics.Blit(renderTexture, temporary5);
				Graphics.Blit(temporary5, destination, this.screenBlend, num11);
				RenderTexture.ReleaseTemporary(temporary5);
			}
			else
			{
				Graphics.Blit(renderTexture, destination, this.screenBlend, num11);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000283E File Offset: 0x00000A3E
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			this.screenBlend.SetFloat("_Intensity", intensity_);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, this.screenBlend, 9);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002868 File Offset: 0x00000A68
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			this.lensFlareMaterial.SetVector("colorA", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.lensFlareMaterial.SetVector("colorB", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.lensFlareMaterial.SetVector("colorC", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.lensFlareMaterial.SetVector("colorD", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, this.lensFlareMaterial);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000029B8 File Offset: 0x00000BB8
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
			this.brightPassFilterMaterial.SetVector("_Threshhold", new Vector4(thresh, thresh, thresh, thresh));
			Graphics.Blit(from, to, this.brightPassFilterMaterial, 0);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000029E1 File Offset: 0x00000BE1
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
			this.brightPassFilterMaterial.SetVector("_Threshhold", threshColor);
			Graphics.Blit(from, to, this.brightPassFilterMaterial, 1);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002A08 File Offset: 0x00000C08
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if (this.lensFlareVignetteMask)
			{
				this.screenBlend.SetTexture("_ColorBuffer", this.lensFlareVignetteMask);
				to.MarkRestoreExpected();
				Graphics.Blit((from == to) ? null : from, to, this.screenBlend, (from == to) ? 7 : 3);
				return;
			}
			if (from != to)
			{
				Graphics.SetRenderTarget(to);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(from, to);
			}
		}

		// Token: 0x04000001 RID: 1
		public Bloom.TweakMode tweakMode;

		// Token: 0x04000002 RID: 2
		public Bloom.BloomScreenBlendMode screenBlendMode = Bloom.BloomScreenBlendMode.Add;

		// Token: 0x04000003 RID: 3
		public Bloom.HDRBloomMode hdr;

		// Token: 0x04000004 RID: 4
		private bool doHdr;

		// Token: 0x04000005 RID: 5
		public float sepBlurSpread = 2.5f;

		// Token: 0x04000006 RID: 6
		public Bloom.BloomQuality quality = Bloom.BloomQuality.High;

		// Token: 0x04000007 RID: 7
		public float bloomIntensity = 0.5f;

		// Token: 0x04000008 RID: 8
		public float bloomThreshold = 0.5f;

		// Token: 0x04000009 RID: 9
		public Color bloomThresholdColor = Color.white;

		// Token: 0x0400000A RID: 10
		public int bloomBlurIterations = 2;

		// Token: 0x0400000B RID: 11
		public int hollywoodFlareBlurIterations = 2;

		// Token: 0x0400000C RID: 12
		public float flareRotation;

		// Token: 0x0400000D RID: 13
		public Bloom.LensFlareStyle lensflareMode = Bloom.LensFlareStyle.Anamorphic;

		// Token: 0x0400000E RID: 14
		public float hollyStretchWidth = 2.5f;

		// Token: 0x0400000F RID: 15
		public float lensflareIntensity;

		// Token: 0x04000010 RID: 16
		public float lensflareThreshold = 0.3f;

		// Token: 0x04000011 RID: 17
		public float lensFlareSaturation = 0.75f;

		// Token: 0x04000012 RID: 18
		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		// Token: 0x04000013 RID: 19
		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		// Token: 0x04000014 RID: 20
		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		// Token: 0x04000015 RID: 21
		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		// Token: 0x04000016 RID: 22
		public Texture2D lensFlareVignetteMask;

		// Token: 0x04000017 RID: 23
		public Shader lensFlareShader;

		// Token: 0x04000018 RID: 24
		private Material lensFlareMaterial;

		// Token: 0x04000019 RID: 25
		public Shader screenBlendShader;

		// Token: 0x0400001A RID: 26
		private Material screenBlend;

		// Token: 0x0400001B RID: 27
		public Shader blurAndFlaresShader;

		// Token: 0x0400001C RID: 28
		private Material blurAndFlaresMaterial;

		// Token: 0x0400001D RID: 29
		public Shader brightPassFilterShader;

		// Token: 0x0400001E RID: 30
		private Material brightPassFilterMaterial;

		// Token: 0x0200003C RID: 60
		public enum LensFlareStyle
		{
			// Token: 0x0400013F RID: 319
			Ghosting,
			// Token: 0x04000140 RID: 320
			Anamorphic,
			// Token: 0x04000141 RID: 321
			Combined
		}

		// Token: 0x0200003D RID: 61
		public enum TweakMode
		{
			// Token: 0x04000143 RID: 323
			Basic,
			// Token: 0x04000144 RID: 324
			Complex
		}

		// Token: 0x0200003E RID: 62
		public enum HDRBloomMode
		{
			// Token: 0x04000146 RID: 326
			Auto,
			// Token: 0x04000147 RID: 327
			On,
			// Token: 0x04000148 RID: 328
			Off
		}

		// Token: 0x0200003F RID: 63
		public enum BloomScreenBlendMode
		{
			// Token: 0x0400014A RID: 330
			Screen,
			// Token: 0x0400014B RID: 331
			Add
		}

		// Token: 0x02000040 RID: 64
		public enum BloomQuality
		{
			// Token: 0x0400014D RID: 333
			Cheap,
			// Token: 0x0400014E RID: 334
			High
		}
	}
}

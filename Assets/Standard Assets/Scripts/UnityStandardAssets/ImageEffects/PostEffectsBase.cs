using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000003 RID: 3
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class PostEffectsBase : MonoBehaviour
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002B88 File Offset: 0x00000D88
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				Debug.Log("Missing shader in " + this.ToString());
				base.enabled = false;
				return null;
			}
			if (s.isSupported && m2Create && m2Create.shader == s)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				this.NotSupported();
				Debug.Log(string.Concat(new string[]
				{
					"The shader ",
					s.ToString(),
					" on effect ",
					this.ToString(),
					" is not supported on this platform!"
				}));
				return null;
			}
			m2Create = new Material(s);
			m2Create.hideFlags = HideFlags.DontSave;
			if (m2Create)
			{
				return m2Create;
			}
			return null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002C40 File Offset: 0x00000E40
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				Debug.Log("Missing shader in " + this.ToString());
				return null;
			}
			if (m2Create && m2Create.shader == s && s.isSupported)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				return null;
			}
			m2Create = new Material(s);
			m2Create.hideFlags = HideFlags.DontSave;
			if (m2Create)
			{
				return m2Create;
			}
			return null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002CB1 File Offset: 0x00000EB1
		private void OnEnable()
		{
			this.isSupported = true;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002CBA File Offset: 0x00000EBA
		protected bool CheckSupport()
		{
			return this.CheckSupport(false);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002CC3 File Offset: 0x00000EC3
		public virtual bool CheckResources()
		{
			Debug.LogWarning("CheckResources () for " + this.ToString() + " should be overwritten.");
			return this.isSupported;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002CE5 File Offset: 0x00000EE5
		protected void Start()
		{
			this.CheckResources();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002CF0 File Offset: 0x00000EF0
		protected bool CheckSupport(bool needDepth)
		{
			this.isSupported = true;
			this.supportHDRTextures = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			this.supportDX11 = SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.NotSupported();
				return false;
			}
			if (needDepth && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.NotSupported();
				return false;
			}
			if (needDepth)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002D67 File Offset: 0x00000F67
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			if (!this.CheckSupport(needDepth))
			{
				return false;
			}
			if (needHdr && !this.supportHDRTextures)
			{
				this.NotSupported();
				return false;
			}
			return true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002D88 File Offset: 0x00000F88
		public bool Dx11Support()
		{
			return this.supportDX11;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002D90 File Offset: 0x00000F90
		protected void ReportAutoDisable()
		{
			Debug.LogWarning("The image effect " + this.ToString() + " has been disabled as it's not supported on the current platform.");
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002DAC File Offset: 0x00000FAC
		private bool CheckShader(Shader s)
		{
			Debug.Log(string.Concat(new string[]
			{
				"The shader ",
				s.ToString(),
				" on effect ",
				this.ToString(),
				" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package."
			}));
			if (!s.isSupported)
			{
				this.NotSupported();
				return false;
			}
			return false;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002E04 File Offset: 0x00001004
		protected void NotSupported()
		{
			base.enabled = false;
			this.isSupported = false;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002E14 File Offset: 0x00001014
		protected void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float num;
				float num2;
				if (flag)
				{
					num = 1f;
					num2 = 0f;
				}
				else
				{
					num = 0f;
					num2 = 1f;
				}
				float num3 = 0f;
				float num4 = 0f + 1f / ((float)dest.width * 1f);
				float num5 = 0f;
				float num6 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, num);
				GL.Vertex3(num3, num5, 0.1f);
				GL.TexCoord2(1f, num);
				GL.Vertex3(num4, num5, 0.1f);
				GL.TexCoord2(1f, num2);
				GL.Vertex3(num4, num6, 0.1f);
				GL.TexCoord2(0f, num2);
				GL.Vertex3(num3, num6, 0.1f);
				float num7 = 1f - 1f / ((float)dest.width * 1f);
				num4 = 1f;
				num5 = 0f;
				num6 = 1f;
				GL.TexCoord2(0f, num);
				GL.Vertex3(num7, num5, 0.1f);
				GL.TexCoord2(1f, num);
				GL.Vertex3(num4, num5, 0.1f);
				GL.TexCoord2(1f, num2);
				GL.Vertex3(num4, num6, 0.1f);
				GL.TexCoord2(0f, num2);
				GL.Vertex3(num7, num6, 0.1f);
				float num8 = 0f;
				num4 = 1f;
				num5 = 0f;
				num6 = 0f + 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, num);
				GL.Vertex3(num8, num5, 0.1f);
				GL.TexCoord2(1f, num);
				GL.Vertex3(num4, num5, 0.1f);
				GL.TexCoord2(1f, num2);
				GL.Vertex3(num4, num6, 0.1f);
				GL.TexCoord2(0f, num2);
				GL.Vertex3(num8, num6, 0.1f);
				float num9 = 0f;
				num4 = 1f;
				num5 = 1f - 1f / ((float)dest.height * 1f);
				num6 = 1f;
				GL.TexCoord2(0f, num);
				GL.Vertex3(num9, num5, 0.1f);
				GL.TexCoord2(1f, num);
				GL.Vertex3(num4, num5, 0.1f);
				GL.TexCoord2(1f, num2);
				GL.Vertex3(num4, num6, 0.1f);
				GL.TexCoord2(0f, num2);
				GL.Vertex3(num9, num6, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0400001F RID: 31
		protected bool supportHDRTextures = true;

		// Token: 0x04000020 RID: 32
		protected bool supportDX11;

		// Token: 0x04000021 RID: 33
		protected bool isSupported = true;
	}
}

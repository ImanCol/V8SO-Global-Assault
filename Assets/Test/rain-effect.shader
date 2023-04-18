Shader "Custom/RainAndFlame" {
	Properties {
		_RainIntensity ("Rain Intensity", Range(0,1)) = 0
		_FlameIntensity ("Flame Intensity", Range(0,1)) = 0
		_FlameColor ("Flame Color", Color) = (1,1,1,1)
		_RainTexture ("Rain Texture", 2D) = "white" {}
	}

	SubShader {
		Tags { "RenderType"="Opaque" }

		Pass {
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			struct appdata {
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f {
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			sampler2D _RainTexture;
			float _RainIntensity;
			float _FlameIntensity;
			float4 _FlameColor;

			v2f vert (appdata v) {
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}

			fixed4 frag (v2f i) : SV_Target {
				fixed4 col = tex2D(_MainTex, i.uv);

				// Add rain effect
				float2 rainUV = i.uv;
				rainUV.y += _Time.y * 0.1;
				col.rgb += tex2D(_RainTexture, rainUV).rgb * _RainIntensity;

				// Add flame effect
				float noise = (tex2D(_MainTex, i.uv * 10).r - 0.5) * 2;
				col.rgb += _FlameColor.rgb * pow(noise, 2) * _FlameIntensity;

				return col;
			}
			ENDCG
		}
	}
	FallBack "Unlit/Texture"
}
Shader "Unlit/OkamiToon" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Texture", 2D) = "white" {}
	}
	
	SubShader {
		Tags {"RenderType"="Opaque" }
		LOD 100
		
		Pass {
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog
			#include "UnityCG.cginc"
			
			struct appdata {
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};
			
			struct v2f {
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
				float4 worldPos : TEXCOORD1;
				float3 worldNormal : TEXCOORD2;
				float3 worldViewDir : TEXCOORD3;
				UNITY_FOG_COORDS(4)
			};
			
			sampler2D _MainTex;
			float4 _MainTex_ST;
			float4 _Color;
			
			v2f vert (appdata v) {
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.worldPos = mul(unity_ObjectToWorld, v.vertex);
				o.worldNormal = UnityObjectToWorldNormal(v.uv.xyzz);
				o.worldViewDir = normalize(UnityWorldSpaceViewDir(o.worldPos));
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target {
				fixed4 col = tex2D(_MainTex, i.uv) * _Color;
				if (col.a <= 0.0) discard;
				float3 rimColor = pow(saturate(dot(i.worldNormal, i.worldViewDir)), 6.5) * _Color.rgb;
				col.rgb += (pow(saturate(dot(i.worldNormal, i.worldViewDir)), 4.0) * rimColor);
				UNITY_APPLY_FOG(i.fogCoord, col.rgb);
				return col;
			}
			ENDCG
		}
	}
	Fallback Off
}
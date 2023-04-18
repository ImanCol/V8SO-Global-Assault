Shader "Custom/Blur2" {
    Properties {
        _MainTex ("Texture", 2D) = "white" {}
        _BlurSize ("Blur Size", Range(0, 10)) = 1
    }
 
    SubShader {
        Tags { "Queue"="Transparent" "RenderType"="Opaque" }
        LOD 100
 
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
            float _BlurSize;
 
            v2f vert (appdata v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }
 
            fixed4 frag (v2f i) : SV_Target {
                fixed4 col = tex2D(_MainTex, i.uv);
                float blurSize = _BlurSize / _ScreenParams.z;
                float2 texelSize = 1.0 / _ScreenParams.xy;
 
                for (int x = -2; x <= 2; x++) {
                    for (int y = -2; y <= 2; y++) {
                        float2 offset = float2(x, y) * texelSize * blurSize;
                        col += tex2D(_MainTex, i.uv + offset);
                    }
                }
 
                return col / 25;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
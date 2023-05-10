Shader "Custom/RenderTextureRoundBorder" {
    Properties {
        _MainTex ("Texture", 2D) = "white" {}
        _BorderWidth ("Border Width", Range(0, 1)) = 0.1
        _Radius ("Border Radius", Range(0, 1)) = 0.1
    }
    SubShader {
        Tags {"Queue"="Transparent" "RenderType"="Opaque" }
        Pass {
            ZWrite Off
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
            float _BorderWidth;
            float _Radius;

            v2f vert (appdata v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target {
                fixed4 col = tex2D(_MainTex, i.uv);
                float2 texCoord = i.uv;
                float2 borderCenter = float2(0.5, 0.5);
                float2 fromCenter = texCoord - borderCenter;
                float dist = length(fromCenter);
                float2 dir = fromCenter / dist;
                float borderWidth = _BorderWidth * (1 - _Radius);
                float border = smoothstep(_Radius, _Radius + borderWidth, dist);
                col.a *= border;
                return col;
            }
            ENDCG
        }
    }
}

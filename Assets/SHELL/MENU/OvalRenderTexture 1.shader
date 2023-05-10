Shader "Custom/RoundedRectRenderTexture" {
    Properties {
        _MainTex ("Texture", 2D) = "white" {}
        _Radius ("Corner Radius", Range(0, 1)) = 0.2
        _BorderSize ("Border Size", Range(0, 0.5)) = 0.1
        _BorderColor ("Border Color", Color) = (0, 0, 0, 0)
    }
    SubShader {
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
            float4 _MainTex_ST;
            float _Radius;
            float _BorderSize;
            float4 _BorderColor;

            v2f vert (appdata v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target {
                // Calculate the distance between the pixel's UV coordinates and the center of the texture
                float2 distance = i.uv - 0.5;
                distance.y *= _MainTex_ST.y / _MainTex_ST.x;
                float distanceFromCenter = length(distance);

                // Calculate the rounded rectangle shape
                float roundedRect = smoothstep(_Radius, _Radius + _BorderSize, distanceFromCenter);

                // If the pixel is outside the rounded rectangle, discard it
                if (roundedRect < 0.5) {
                    discard;
                }

                // Calculate the border
                float border = smoothstep(_Radius + _BorderSize, _Radius + _BorderSize * 2.0, distanceFromCenter);

                // If the pixel is inside the border, color it with the border color
                if (border > 0.5) {
                    return _BorderColor;
                }

                // Sample the texture
                fixed4 color = tex2D(_MainTex, i.uv);
                return color;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}

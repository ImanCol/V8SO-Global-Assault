Shader "Custom/ChristmasLights" {
    Properties {
        _MainTex ("Texture", 2D) = "white" {}
        _Color ("Color", Color) = (1,1,1,1)
        _ScrollSpeed ("Scroll Speed", Range(0,2)) = 1
        _LightSize ("Light Size", Range(0,0.5)) = 0.2
        _LightIntensity ("Light Intensity", Range(0,1)) = 0.5
    }
 
    SubShader {
        Tags { "RenderType"="Opaque" }
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
            float4 _MainTex_ST;
            float4 _Color;
            float _ScrollSpeed;
            float _LightSize;
            float _LightIntensity;
 
            float4 frag (v2f i) : SV_Target {
                float4 col = tex2D(_MainTex, i.uv);
                float time = _Time.y * _ScrollSpeed;
                float red = sin(time) * 0.5 + 0.5;
                float green = cos(time) * 0.5 + 0.5;
                float blue = sin(time + 3.14) * 0.5 + 0.5;
                float3 lightColor = float3(red, green, blue);
                float lightSize = _LightSize * 1.5;
                float4 light = float4(0,0,0,0);
                float dist = distance(i.uv, float2(0.5, 0.5));
                if (dist < 0.25) {
                    light = float4(lightColor * _LightIntensity, 1);
                }
                float mask = smoothstep(lightSize, lightSize + 0.01, dist);
                col.rgb = lerp(col.rgb, light.rgb, mask);
                col.rgb *= _Color.rgb;
                return col;
            }
 
            v2f vert (appdata v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
Shader "Custom/Noise"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color ("Tint", Color) = (1,1,1,1)
        _BlinkSpeed ("Blink Speed", Range(0, 5)) = 1
        _BlinkSize ("Blink Size", Range(0, 1)) = 0.5
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            
            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };
            
            sampler2D _MainTex;
            float4 _MainTex_ST;
            float4 _Color;
            float _BlinkSpeed;
            float _BlinkSize;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // Calculate a random value to use as the blink offset
                float randVal = frac(sin(dot(i.uv + _Time.y * _BlinkSpeed, float2(12.9898,78.233))) * 43758.545);
                
                // Apply the blinking effect to the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                if (randVal > _BlinkSize) {
                    col = fixed4(0, 0, 0, 0);
                }
                
                // Apply the color tint to the texture
                col *= _Color;
                return col;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
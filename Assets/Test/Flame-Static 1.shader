Shader "Custom/TranslucentDistortedGlow"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _GlowColor ("Glow Color", Color) = (1,1,1,1)
        _GlowStrength ("Glow Strength", Range(0,5)) = 1.5
        _DistortionStrength ("Distortion Strength", Range(0,0.5)) = 0.1
        _DistortionSpeed ("Distortion Speed", Range(-5,5)) = 0.5
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
            float4 _GlowColor;
            float _GlowStrength;
            float _DistortionStrength;
            float _DistortionSpeed;
 
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }
 
            fixed4 frag (v2f i) : SV_Target
            {
                // Sample the texture
                fixed4 texColor = tex2D(_MainTex, i.uv);
 
                // Calculate the distance from the current pixel to the center of the screen
                float2 center = float2(0.5, 0.5);
                float dist = length(i.uv - center);
 
                // Calculate the glow effect
                fixed3 glowColor = _GlowColor.rgb * _GlowStrength * smoothstep(0, 1, dist);
 
                // Calculate the distortion effect
                float xOffset = sin(i.uv.y * _DistortionSpeed) * _DistortionStrength;
                float yOffset = sin(i.uv.x * _DistortionSpeed) * _DistortionStrength;
 
                // Add the glow and distortion effects to the texture color
                fixed4 finalColor = texColor + float4(glowColor, 1);
                finalColor.rgb += tex2D(_MainTex, i.uv + float2(xOffset, yOffset)).rgb * _DistortionStrength;
 
                // Return the final color
                return finalColor;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
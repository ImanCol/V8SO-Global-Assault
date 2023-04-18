Shader "Unlit/BlurShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _BlurAmount ("Blur Amount", Range(0.0, 10.0)) = 1.0
    }
 
    SubShader
    {
        Tags {"Queue"="Transparent" "RenderType"="Opaque"}
        LOD 100
 
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
            float _BlurAmount;
 
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }
 
            fixed4 frag (v2f i) : SV_Target
            {
                float4 color = 0;
                float blurSize = _BlurAmount / _ScreenParams.z;
 
                color = tex2D(_MainTex, i.uv) * 4;
                color += tex2D(_MainTex, i.uv + float2(blurSize, 0)) * 2;
                color += tex2D(_MainTex, i.uv - float2(blurSize, 0)) * 2;
                color += tex2D(_MainTex, i.uv + float2(0, blurSize)) * 2;
                color += tex2D(_MainTex, i.uv - float2(0, blurSize)) * 2;
                color += tex2D(_MainTex, i.uv + float2(blurSize, blurSize));
                color += tex2D(_MainTex, i.uv - float2(blurSize, blurSize));
                color /= 16;
 
                return color;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
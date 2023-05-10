Shader "Custom/RoundedCorners" {
    Properties {
        _MainTex ("Texture", 2D) = "white" {}
        _CornerRadius ("Corner Radius", Range(0, 0.5)) = 0.1
    }
 
    SubShader {
        Tags {"Queue"="Transparent" "RenderType"="Opaque"}
        LOD 100
 
        CGPROGRAM
        #pragma surface surf Lambert alpha
 
        sampler2D _MainTex;
        float _CornerRadius;
 
        struct Input {
            float2 uv_MainTex;
        };
 
        void surf (Input IN, inout SurfaceOutput o) {
            // Calculate distance from each corner
            float2 dist = float2(1, 1) - abs(2 * IN.uv_MainTex - 1);
            float cornerDist = min(dist.x, dist.y);
 
            // Apply corner radius
            float mask = saturate(cornerDist - _CornerRadius);
 
            // Apply mask to alpha channel
            o.Alpha = mask;
 
            // Sample the texture
            o.Albedo = tex2D(_MainTex, IN.uv_MainTex).rgb;
        }
        ENDCG
    }
 
    FallBack "Diffuse"
}

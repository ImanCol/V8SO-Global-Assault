Shader "UI/RoundedCorners/RoundedCorners" {
    Properties {
         _MainTex ("Texture", 2D) = "white" {}

        // --- Mask support ---
         _StencilComp ("Stencil Comparison", Float) = 8
         _Stencil ("Stencil ID", Float) = 0
         _StencilOp ("Stencil Operation", Float) = 0
         _StencilWriteMask ("Stencil Write Mask", Float) = 255
         _StencilReadMask ("Stencil Read Mask", Float) = 255
         _ColorMask ("Color Mask", Float) = 15
         _UseUIAlphaClip ("Use Alpha Clip", Float) = 0

        // Definition in Properties section is required to Mask works properly
        _WidthHeightRadius ("WidthHeightRadius", Vector) = (0,0,0,0)
        // ---
    }
    
    SubShader {
       Tags {
            "RenderType"="Opaque"
            "Queue"="Opaque"
        }
        LOD 100

        // --- Mask support ---
        Stencil {
            Ref [_Stencil]
            Comp [_StencilComp]
            Pass [_StencilOp]
            ReadMask [_StencilReadMask]
            WriteMask [_StencilWriteMask]
        }
        Cull Off
        Lighting On
        ZTest [unity_GUIZTestMode]
        ColorMask [_ColorMask]
        // ---
        
        Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha
        ZWrite On

        Pass {
            CGPROGRAM 
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #include "UnityUI.cginc"          
            #include "SDFUtils.cginc"
            #include "ShaderSetup.cginc"
            
        
            #pragma multi_compile_local _ UNITY_UI_CLIP_RECT
            #pragma multi_compile_local _ UNITY_UI_ALPHACLIP

            float4 _WidthHeightRadius;
            sampler2D _MainTex;
            fixed4 _TextureSampleAdd;
            float4 _ClipRect;

            fixed4 frag (v2f i) : SV_Target {
                half4 color = (tex2D(_MainTex, i.uv) + _TextureSampleAdd) * i.color;

                #ifdef UNITY_UI_CLIP_RECT
                color.a *= UnityGet2DClipping(i.worldPosition.xy, _ClipRect);
                #endif

                #ifdef UNITY_UI_ALPHACLIP
                clip(color.a - 0.001);
                #endif

                if (color.a <= 0) {
                    return color;
                }

                float alpha = CalcAlpha(i.uv, _WidthHeightRadius.xy, _WidthHeightRadius.z);

                #ifdef UNITY_UI_ALPHACLIP
                clip(alpha - 0.001);
                #endif
                
                return mixAlpha(tex2D(_MainTex, i.uv), i.color, alpha);
            }
            
            ENDCG
        }
    }
}

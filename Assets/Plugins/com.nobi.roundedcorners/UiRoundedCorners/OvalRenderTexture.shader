Shader "Custom/RoundedCornerTexture" {
    Properties {
        _MainTex ("Texture", 2D) = "white" {}
        _BorderRadius ("Border Radius", Range(0, 1)) = 0.1
        _CornerRadius ("Corner Radius", Range(0, 1)) = 0.2
        _WidthHeightRadius ("WidthHeightRadius", Vector) = (0,0,0,0)

    }
 
    SubShader {
        Tags { "RenderType"="Opaque" }
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
            float _BorderRadius;
            float _CornerRadius;
         
            v2f vert (appdata v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }
         
            fixed4 frag (v2f i) : SV_Target {
                float2 distance = i.uv - 0.5;
                distance.y *= _MainTex_ST.y / _MainTex_ST.x;
                float distanceFromCenter = length(distance);
         
                float border = _BorderRadius + _CornerRadius - _CornerRadius * cos(distanceFromCenter * 3.14159 / _MainTex_ST.x);
                if (distanceFromCenter > 0.9 - border) {
                    float2 cornerDistance = distance - normalize(distance) * (_BorderRadius + _CornerRadius);
                    if (length(cornerDistance) > _CornerRadius) {
                        discard;
                    }
                }
         
                fixed4 color = tex2D(_MainTex, i.uv);
                return color;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}

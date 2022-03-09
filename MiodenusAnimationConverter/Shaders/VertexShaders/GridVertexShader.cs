using OpenTK.Graphics.OpenGL;

namespace MiodenusAnimationConverter.Shaders.VertexShaders
{
    public static class GridVertexShader
    {
        public const ShaderType Type = ShaderType.VertexShader;
        public const string Code = @"
                #version 330 core

                layout (location = 0) in vec3 position;
                layout (location = 1) in vec4 color;
                layout (location = 2) in bool is_visible;

                out VertexShaderOutput
                {
                    bool is_visible;
                    vec4 color;
                } vertex;

                uniform mat4 view;
                uniform mat4 projection;

                void main(void)
                {
                    vertex.is_visible = is_visible;
                    vertex.color = color;
                    gl_Position = projection * view * vec4(position, 1.0f);
                }
                ";
    }
}
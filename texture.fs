#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture1;
uniform vec4 colorChanger;

void main()
{	
    vec4 texColor = texture(texture1, TexCoords) * colorChanger;
    if(texColor.a < 0.1)
        discard;
    FragColor = texColor;
}
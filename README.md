# CMPM163Labs
A public repo for CMPM163 class
Lab2:

Part1 :https://drive.google.com/open?id=1lgWhqeKB6sLize_V0O_QIYcWUl8qTaAb

Part2: ![](ImagesForReadMe/lab2pic.png)

---------------------------------------------------------------------------
Lab3:

video:

Cubes explaining:
1. The cube in the middel: this is cube from the part1 instruction. I did not change anything for that.
2. the spaning blue cube: this is the cube that I made for the part1, I changed its colors to blue, and change metalness to 0.9 and metalness ato 0.5.
3. the spaning red cube: this is also for the part1, I changed the colors to red and add change transparency to 0.8.
4. the right cube: this is cube from the part2 instruction. I change it colors to 0xAF0FAF and 0x0000FF.
5. the left cube: this is the cube I made for the part2. My shader formula is gl_FragColor = vec4(mix(min(colorA,colorB)/st.x,max(colorB,colorC)/st.x, vUv.z), 1.0);. I passed four uniforms to the shader. They are colorsA, B, C and resolution. So it will take smaller color bewteen A and B, and bigger color bewteen B and C. Then make them devide by the st.x(gl_FragCoord.xy/u_resolution). Then mixed two colors together to get my cube.


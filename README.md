# CMPM163Labs
A public repo for CMPM163 class
Lab2:

Part1 :https://drive.google.com/open?id=1lgWhqeKB6sLize_V0O_QIYcWUl8qTaAb

Part2: ![](ImagesForReadMe/lab2pic.png)

---------------------------------------------------------------------------
Lab3:

video: https://drive.google.com/open?id=1M7jcxzOoDhuZ2sfECTCjvgTY8vWr_xJV

Cubes explaining:
1. The cube in the middle: this is cube from the part1 instruction. I did not change anything for that.
2. the spaning blue cube: this is the cube that I made for the part1, I changed its colors to blue, and change metalness to 0.9 and metalness ato 0.5.
3. the spaning red cube: this is also for the part1, I changed the colors to red and change transparency to 0.8.
4. the right cube: this is cube from the part2 instruction. I change it colors to 0xAF0FAF and 0x0000FF.
5. the left cube: this is the cube I made for the part2. My shader formula is gl_FragColor = vec4(mix(min(colorA,colorB)/st.x,max(colorB,colorC)/st.x, vUv.z), 1.0);. I passed four uniforms to the shader. They are colorsA, B, C and resolution. So it will take smaller color bewteen A and B, and bigger color bewteen B and C. Then make them devide by the st.x(gl_FragCoord.xy/u_resolution). Then mixed two colors together to get my cube.

---------------------------------------------------------------------------
Lab4: 

Video:   https://drive.google.com/open?id=1ny9-C2TpoFOmApPTDefOQVnJK0uxH4Vr

Answers for part1:
a. Floor(7u).
b. Floor(7-7v).
c. Answer is Grey. From the Equation Above, Floor(7*0.375) = 2 and Floor(7-7*0.25) = 5 so (2,5), which is grey in the texture.

Cubes explaining:
1. The left cube is from the part A, which contain the texture, it is without the normal map.
2. the middel cube is from the partA, it contains the texture and normal map.
3. the top cube is from the partA, It has new texture and normal map.
4. the right cube is from the partB, it was built with the shader that instruction provided.
5. the button tiled cube is from the partB, it was built with my shader that samples the texture to four parts. the formula:   gl_FragColor = texture2D(texture2, 2.0*mod(vUv, 0.5));. In the shader, I first used the mod function to make texture four different parts, then I let the result of that multiple by 2, which scale the result and let it distributed properly.


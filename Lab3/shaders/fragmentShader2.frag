varying vec3 vUv;
uniform vec3 colorA;
uniform vec3 colorB;
uniform vec3 colorC;
uniform vec2 u_resolution;


void main() {

    vec2 st = gl_FragCoord.xy/u_resolution;
  gl_FragColor = vec4(mix(min(colorA,colorB)/st.x,max(colorB,colorC)/st.x, vUv.z), 1.0);

}

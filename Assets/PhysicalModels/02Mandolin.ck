Mandolin mand => dac;
[79, 78, 74, 78, 76, 72] @=> int solomio[];
for (0 => int i; i < solomio.cap(); i++) 
{ 
    Std.mtof(solomio[i]) => mand.freq; 
    Math.random2f(0.01,0.9) => mand.pluckPos; 
    Math.random2f(0.05,0.11) => mand.stringDetune; 
    for (0 => int trem; trem < 12; trem++)
    {
        1 => mand.noteOn;
        Math.random2f(0.06,0.09) :: second => now; 
    }
}

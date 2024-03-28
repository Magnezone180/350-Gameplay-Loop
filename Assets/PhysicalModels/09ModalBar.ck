// Demo of modal bar presets
ModalBar bar => dac;
while (true) 
{  
    // pick a random object type 
    1 => bar.preset;
    // and random frequency 
    400 => bar.freq; 
    // Then whack it!!
    1 => bar.noteOn;
    0.4 :: second => now;
}

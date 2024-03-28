// Test some Bowed parameters 
Bowed viol => dac;
for(1=>int i; i<=5; i++)
{
    for(1=>int j;j<=5;j++)
    {
        i*0.2 => viol.bowPressure;
        j*0.2 => viol.bowPosition; 
        <<< "pres=", i*0.2, "pos=", j*0.2 >>>; 1 => viol.noteOn;
        0.3 :: second => now;
        1 => viol.noteOff;
        0.1 :: second => now;
    }
}

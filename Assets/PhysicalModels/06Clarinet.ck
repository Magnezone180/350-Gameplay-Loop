Clarinet c => dac;

while(true)
{
220 => c.freq;

Math.random2f(.1, 1) => c.noteOn;
.2::second => now;
1 => c.noteOff;
.5::second => now;

}
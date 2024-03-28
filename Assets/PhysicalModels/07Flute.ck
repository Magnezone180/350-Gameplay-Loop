Flute f => dac;

while(true)
{
440 => f.freq;

1.0 => f.noteOn;
Math.random2f(.1, 1) => f.jetDelay;  // blowing parameter
.2::second => now;
1 => f.noteOff;
.5::second => now;

}
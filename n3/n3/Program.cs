using NAudio.Midi;
using System;
using System.Threading;
namespace n3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int keyPressed;
            MidiOut midiOut = new MidiOut(0);
            //                             C   C#  D   D#  E   F   F#  G   G#  A   A#  B
            //                             0   1   2   3   4   5   6   7   8   9   10  11
            int[] NotesFrenq = new int[] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };
            int Note;
            int Octave = 1;

            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = Convert.ToInt32(keyInfo.Key);

                switch (keyPressed)
                {
                    case 9: //С 
                        Note = NotesFrenq[0] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 49: //С# 
                        Note = NotesFrenq[1] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 81: //D 
                        Note = NotesFrenq[2] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 50: //D#
                        Note = NotesFrenq[3] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 87: //E
                        Note = NotesFrenq[4] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 69: //F 
                        Note = NotesFrenq[5] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 52: //F#
                        Note = NotesFrenq[6] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 82: //G 
                        Note = NotesFrenq[7] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 53: //G#
                        Note = NotesFrenq[8] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 84: //A 
                        Note = NotesFrenq[9] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 54: //A# 
                        Note = NotesFrenq[10] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 89: //B
                        Note = NotesFrenq[11] + (12 * Octave);
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;

                    case 85: //С
                        Note = NotesFrenq[0] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 56: //С#
                        Note = NotesFrenq[1] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 73: //D 
                        Note = NotesFrenq[2] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 57: //D# 
                        Note = NotesFrenq[3] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 79: //E 
                        Note = NotesFrenq[4] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 80: //F
                        Note = NotesFrenq[5] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 189: //F#
                        Note = NotesFrenq[6] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 26: //G 
                        Note = NotesFrenq[7] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 186: //G#
                        Note = NotesFrenq[8] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 27: //A 
                        Note = NotesFrenq[9] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 14: //A# 
                        Note = NotesFrenq[10] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 220: //B
                        Note = NotesFrenq[11] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;
                    case 13: //B
                        Note = NotesFrenq[11] + (12 * (Octave + 1));
                        midiOut.Send(MidiMessage.StartNote(Note, 127, 1).RawData);
                        break;

                    case 112:
                        Octave--;
                        if (Octave <= 0) Octave = 7;
                        break;
                    case 113:
                        Octave++;
                        if (Octave >= 8) Octave = 1;
                        break;
                }
            } while (true);

        }
    }
}

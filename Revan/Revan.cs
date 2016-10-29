﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revan
{
    public class Revan
    {
        IBulb display;
        IEncoder encoder;
        IParser parser;
        IFormatter formatter;
        IAccent accent;

        public int mod;
        public string output;

        public Revan()
        {
            // for now we will set the mod to 5
            this.mod = 5;

            this.display = new YOBulb();
            this.encoder = new StandardEncoder(this);
            this.parser = new StandardParser(this);
            this.formatter = new StandardFormatter(this);
            this.accent = new QuarterAccent(this, new ROBulb());
        }

        void write(int chunks, int upperBound, bool withoutAccent = false)
        {
            for (int i = 1; i <= upperBound; i++)
            {
                if (i <= chunks)
                {
                    if ((this.accent.check(i, upperBound)) && !withoutAccent)
                    {
                        this.formatter.add(this.accent.Display.on());
                    } else
                    {
                        this.formatter.add(this.display.on());
                    }
                } else
                {
                    this.formatter.add(this.display.off());
                }
            }
        }


        // The first value in the tuple returns the mod, the second returns the remainder
        // Display the time in the revan format
        public string show(int hour, int minute, int second)
        {
            this.output = "";
            Tuple<int, int> hourRows = this.encoder.calculateRows(24, this.mod);
            Tuple<int, int> minuteRows = this.encoder.calculateRows(60, this.mod);
            Tuple<int, int> hourChunks = this.encoder.encode(hour);
            Tuple<int, int> minuteChunks = this.encoder.encode(minute);

            // The bulb at the top
            if (second % 2 == 0 || second == 0)
            {
                this.formatter.add(this.display.on());
                this.formatter.addBuffer();
            } else
            {
                this.formatter.add(this.display.off());
                this.formatter.addBuffer();
            }

            // The hour bulbs
            write(hourChunks.Item1, hourRows.Item1);
            this.formatter.addBuffer();
            write(hourChunks.Item2, hourRows.Item2);
            this.formatter.addBuffer();

            // The minute bulbs
            write(minuteChunks.Item1, minuteRows.Item1);
            this.formatter.addBuffer();
            write(minuteChunks.Item2, minuteRows.Item2, true);
            this.formatter.addBuffer();


            return this.output; 
        }

        public string parse(Object rawString)
        {
            this.output = "";

            HMS hms = this.parser.parse(rawString);

            return show(hms.hour, hms.minute, hms.second);
        }

        public void setParser(IParser newParser)
        {
            this.parser = newParser;
        }
    }
}
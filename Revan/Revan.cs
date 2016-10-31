using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revan
{
    public class RevanClock
    {
        private IBulb _bulb;
        private IEncoder encoder;
        private IParser parser;
        private IFormatter formatter;
        private IAccent accent;

        public RevanClock()
        {
            // for now we will set the mod to 5
            this._bulb = new YOBulb();
            this.encoder = new StandardEncoder(5);
            this.parser = new StandardParser();
            this.formatter = new StandardFormatter();
            this.accent = new QuarterAccent(new ROBulb());
        }

        // The write method uses the aggregate objects to write the bulbs to the formatter.
        // chunks = number of ON bulbs
        // upperBound = number of bulbs in the current row
        void write(int chunks, int upperBound, bool withoutAccent = false)
        {
            for (int i = 1; i <= upperBound; i++)
            {
                if (i <= chunks)
                {
                    if ((this.accent.check(i, upperBound)) && !withoutAccent)
                    {
                        this.formatter.add(this.accent.Bulb.on());
                    } else
                    {
                        this.formatter.add(this._bulb.on());
                    }
                } else
                {
                    this.formatter.add(this._bulb.off());
                }
            }
        }


        // The first value in the tuple returns the mod, the second returns the remainder
        // Display the time in the revan format
        public string show(int hour, int minute, int second)
        {
            this.formatter.reset();
            Tuple<int, int> hourRows = this.encoder.calculateRowLength(24);
            Tuple<int, int> minuteRows = this.encoder.calculateRowLength(60);
            Tuple<int, int> hourChunks = this.encoder.encode(hour);
            Tuple<int, int> minuteChunks = this.encoder.encode(minute);

            // The bulb at the top
            if (second % 2 == 0 || second == 0)
            {
                this.formatter.add(this._bulb.on());
                this.formatter.addBuffer();
            } else
            {
                this.formatter.add(this._bulb.off());
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
            //this.formatter.addBuffer();


            return this.formatter.Output;
        }

        public string parse(Object rawDate)
        {
            HMS hms = this.parser.parse(rawDate);
            return show(hms.hour, hms.minute, hms.second);
        }


        // Defining the getters and setters to swap out poritions of the display logic
        public IParser Parser
        {
            get { return this.parser; }
            set { this.parser = value; }
        }
        public IBulb Bulb
        {
            get { return this._bulb; }
            set { this._bulb = value; }
        }
        public IAccent Accent
        {
            get { return this.accent; }
            set { this.accent = value; }
        }
        public IFormatter Formatter
        {
            get { return this.formatter; }
            set { this.formatter = value; }
        }
        public IEncoder Encoder
        {
            get { return this.encoder; }
            set { this.encoder = value; }
        }
    }
}

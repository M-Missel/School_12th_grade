using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public enum Direction { right, down, left, up };

    class Steuerung
    {
        private int rowcount = 20;
        private int colcount = 30;
        private SnakePart coin;
        private SnakePart head;
        private List<SnakePart> tail;
        private Direction dir;
        private GUI dieGUI;
        private List<Direction> futureDirs = new List<Direction>();
        private int punkte;
        private System.Windows.Forms.Timer timerSnake;

        public Steuerung(GUI pGUI)
        {
            this.dieGUI = pGUI;
            timerSnake = new System.Windows.Forms.Timer();
            this.timerSnake.Interval = 35;
            this.timerSnake.Tick += new System.EventHandler(this.timerSnake_Tick);
            initGame();
        }

        private void timerSnake_Tick(object sender, EventArgs e)
        {
            dieGUI.Refresh();
        }

        public void initGame()
        {
            punkte = 0;
            dir = Direction.right;
            head = new SnakePart(10,10);
            tail = new List<SnakePart>();
            coin = searchFree();
            dieGUI.setGameSize(colcount, rowcount);
            timerSnake.Start();
            tick();
        }

        private SnakePart searchFree()
        {
            Random random = new Random();
            int x = 0, y = 0;
            bool rep = true;

            while (rep)
            {
                x = random.Next(1, 31);
                y = random.Next(1, 21);

                if (isHeadAt(x, y) == false && isTailPart(x, y) == false)
                {
                    rep = false;
                }
            }

            return new SnakePart(x, y);

        }

        public bool isCoinAt(int x, int y)
        {
            return coin.isAt(x,y);
        }

        public bool isHeadAt(int x, int y)
        {
            return head.isAt(x, y);
        }

        public bool isTailPart(int x, int y)
        {
            foreach (SnakePart tailpart in tail)
            {
                if (tailpart.isAt(x, y))
                {
                    return true;
                }
            }
            return false;
        }

        private void tick()
        {
            int newx, newy;

            setNewDir();

            newx = head.X;
            newy = head.Y;

            switch (dir)
            {
                case Direction.right:
                    newx++;
                    break; 
                case Direction.down:
                    newy++;
                    break;
                case Direction.left:
                    newx--;
                    break;
                case Direction.up:
                    newy--;
                    break;
            }

            if (newx >= 0 && newx < colcount && newy > 0 && newy < rowcount && isTailPart(newx, newy) == false)
            {
                tail.Add(new SnakePart(newx, newy));

                if (isCoinAt(newx, newy))
                {
                    coin = searchFree();

                    dieGUI.zeigePunkte(punkte++);
                }
                else
                {
                    tail.RemoveAt(0);
                }

                head.X = newx;
                head.Y = newy;
            }
            else
            {
                pauseGame();

                dieGUI.zeigeVerloren();
            }
        }

        public void pauseGame()
        {
            timerSnake.Enabled = !timerSnake.Enabled;
        }

        private void setNewDir()
        {
            if (futureDirs.Count > 0)
            {
                dir = futureDirs.First<Direction>();
                futureDirs.RemoveAt(0);
            }
        }

        public void changeDirectionIfPossible(Direction newdir)
        {
            Direction lastdir = dir;
            if (futureDirs.Count > 0)
            {
                lastdir = futureDirs.Last<Direction>();
            }
            if (((int)newdir) % 2 != ((int)lastdir % 2))
            {
                futureDirs.Add(newdir);
            }
        }
    }
}

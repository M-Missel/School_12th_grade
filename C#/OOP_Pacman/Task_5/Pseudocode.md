OPERATION berechneRichtung() : GZ
    dieRichtung <- 0
    YPacMan <- PacMan.gibY()
    XPacMan <- PacMan.gibX()

    WENN YPacMan = Geist[i].gibPosY() UND XPacMan = Geist[i].gibPosX()
        RÜCKGABE dieRichtung <- 0
    ENDE WENN

    xPosRichtung <- XPacMan - Geist[i].gibPosX()
    yPosRichtung <- YPacMan - Geist[i].gibPosY()

    

RÜCKGABE dieRichtung
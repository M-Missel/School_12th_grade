# Data aggregation

The following tables are given in a database:

1. Personen(<ins>PersNr</ins>, PersName, **AbtNr**)
2. Abteilungen(<ins>AbtNr</ins>, AbtName)
3. Projekte(<ins>PrjNr</ins>, PrjName)
4. Projektstunden(**PersNr**, **PrjNr**, PrjStd)

## Task: Express the following queries as SQL statements

1. All persons with PersNr, PersName and AbtName
``` SQL
SELECT p.PersNr, p.PersName, a.AbtName
FROM Personen p
     Abteilungen a

WHERE p.AbtNr = a.Abtnr
ORDER BY ASC
```

2. All project hours with PersNr, PrjName and PrjStd
``` SQL
SELECT pe.PersNr, pr.PrjName, SUM(pj.PrjStd) as 'Anzahl Stunden'
FROM Personen pe,
     Projekt pr,
     Projektstunden pj

WHERE pe.PersNR = pj.PersNr AND pr.PrjNr = pj.PrjNr
GROUP BY pe.PersNR
```

3. All project hours with PersName, PrjName and PrjStd
``` SQL
SELECT pe.PersName, pr.PrjName, SUM(pj.PrjStd) as 'Anzahl Stunden'
FROM Personen pe,
     Projekt pr,
     Projektstunden pj

WHERE pe.PersNR = pj.PersNr AND pr.PrjNr = pj.PrjNr
GROUP BY pe.PersName
```

4. The mapping PersNr and total number of PrjStd of this PersNr
``` SQL
SELECT p.PersNr, SUM(pj.PrjStd)
FROM Personen p,
     Projektstunden pj

WHERE p.PersNr = pj.PersNr
GROUP BY p.PersNR
```

5. The mapping project name and total number of PrjStd of this project
``` SQL
SELECT p.PrjName, SUM(pj.PrjStd)
FROM Projekt p,
     Projektstunden pj

WHERE p.PrjNr = pj.PrjNr
GROUP BY p.PrjNr
```

6. The mapping PersName and total number of PrjStd of this employee
``` SQL
SELECT p.PersName, SUM(pj.PrjStd)
FROM Personen p,
     Projektstunden pj

WHERE p.PersNr = pj.PersNR
GROUP BY p.PersName
```
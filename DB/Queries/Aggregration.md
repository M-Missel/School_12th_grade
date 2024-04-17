# Data aggregation

The following tables are given in a database:

1. schueler(id, name, vorname, gebdat, klasse_id, tutor_id)
2. lehrer(id, name, vorname)
3. klasse(id, name)
4. fach(id, name)
5. klasse_fach(id_klasse_id, fach_id, stunden)

## Task: Express the following queries as SQL statements

1.  Number of students in the database

``` SQL
 SELECT COUNT(*) as Anzahl
 FROM schueler
```

2. Number of hours per week for class TGI 12 (class_id=1)

``` SQL
SELECT SUM(stunden) as Anzahl
FROM klasse_fach
WHERE klasse_id = 1
```

3.  Number of students for each class

``` SQL
SELECT COUNT(id) as Anzahl
FROM schueler
GROUP BY klasse_id
```

4. youngest student at the school

``` SQL
SELECT MAX(gebdat), name, vorname
FROM schueler
```

5. Date of birth of the student at the youngest age

```SQL
SELECT MAX(gebdat), gebdat, name, vorname
FROM schueler
```

6. Number of hours per week for each class

```SQL
SELECT SUM(stunden) as Wochenstunden, klasse_id
FROM klasse_fach
GROUP BY klasse_id
```

7. Number of subjects in each class

```SQL
SELECT SUM(fach_id) as Anzahl_Stunden, klasse_id
FROM klasse_fach
GROUP BY klasse_id
```

8. Number of math lessons (id=1)

```SQL
SELECT SUM(stunden) as Mathestunden
FROM klasse_fach
WHERE fach_id = 1
```

9.  Average number of hours in each subject

```SQL
SELECT AVG(stunden) as Durchschnitt, fach_id
FROM klasse_fach
GROUP BY fach_id
```

10. Number of lessons per subject

```SQL
SELECT SUM(stunden), fach_id
FROM klasse_fach
GROUP BY fach_id
ORDER BY SUM(stunden) DESC
```

11. Number of students for whom a teacher is a tutor

```SQL
SELECT COUNT(id)
FROM schueler
GROUP BY tutor_id
```
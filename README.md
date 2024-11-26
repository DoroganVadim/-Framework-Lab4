# Lucrare de laborator nr. 4. Formulare și validarea datelor

## Scopul lucrării
Familiarizarea cu elementele de bază ale creării și gestionării formularelor
Deprinderea mecanismelor de validare a datelor pe server, utilizarea regulilor de validare predefinite și personalizate, precum și învățarea gestionării erorilor și asigurarea securității datelor.

## Condiții
În această lucrare de laborator, veți crea formulare HTML, implementați verificarea datelor pe partea de server și asigurați interacțiunea sigură cu utilizatorul, prevenind vulnerabilități precum XSS și CSRF.

## Sarcina Nr. 1. Crearea formularului
1. Creați un formular pentru adăugarea unei sarcini noi:
    1. Formularul trebuie să conțină următoarele câmpuri: Titlu, Descriere, Data limită, Categorie.
    
    2. Folosiți șabloanele Blade pentru a reda formularul.

    3. Câmpul Categorie trebuie să fie o listă derulantă, încărcată din tabelul de categorii din baza de date.

    4. Asigurați-vă că formularul trimite date prin metoda POST către o rută creată pentru procesarea datelor.
    Codul:\
    ![image](./screenshots/1.1.1.png)
    vizualizarea:\
    ![image](./screenshots/1.1.2.png)
2. Actualizați controllerul TaskController:
    1. Adăugați metoda create, care returnează vizualizarea cu formularul.
    2. Adăugați metoda store, care procesează datele din formular și le salvează.\
    ![image](./screenshots/1.2.png)

## Sarcina Nr. 2. Validarea datelor pe partea de server
Datele validate in clasa task:\
![image](./screenshots/2.1.png)

Metoda store() a controlerului task:\
![image](./screenshots/2.2.png)

Reprezentarea in vizualizare:\
![image](./screenshots/2.3.png)

## Sarcina Nr. 3. Validarea datelor pe partea de server
1. Actualizați formularul HTML pentru a afișa un mesaj de confirmare la salvarea cu succes a sarcinii (mesaj flash).
2. Actualizați metoda store a controllerului TaskController pentru a adăuga un mesaj flash la salvarea cu succes a sarcinii.

Afișarea mesajului:
![image](./screenshots/3.1.png)

Cum a fost implementat:
- În moetoda store:
![image](./screenshots/3.2.png)

- În vizualizare:\
![image](./screenshots/3.3.png)

## Sarcina Nr. 4. Protecția împotriva CSRF
- Adăugați directiva @csrf în formular pentru protecția împotriva atacurilor CSRF.\
![image](./screenshots/4.1.png)
- Asigurați-vă că formularul este trimis doar prin metoda POST.\
![image](./screenshots/4.2.png)

## Sarcina Nr. 5. Actualizarea sarcinii
1. Adăugați posibilitatea de editare a sarcinii:
    Vizualizarea Edit(cod):\
    ![image](./screenshots/5.1.png)

    Vizualizarea Edit(la execuție):\
    ![image](./screenshots/5.2.png)

    Metoda Update() cu validarea datelor:\
    ![image](./screenshots/5.3.png)
FirstProgram – Programdokumentáció

Projekt neve: FirstProgram
Programozási nyelv: C#
Alkalmazás típusa: Konzolalkalmazás
Fő forrásfájl: Program.cs
GitHub-repozitórium: https://github.com/NERO2204/FirstProgram

1. A program bemutatása

A FirstProgram egy egyszerű, oktatási célú C# konzolalkalmazás. A projekt célja a C# programozási nyelv alapvető elemeinek megismerése és gyakorlása.

A program különböző változótípusokat, matematikai műveleteket, típuskonverziókat és feltételes elágazásokat mutat be.

A forráskód egyes részei kommentként szerepelnek, így azok későbbi gyakorlásra és továbbfejlesztésre használhatók.

2. A fejlesztés környezete

A projekt a következő technológiákat használja:

C# programozási nyelv.
.NET futtatókörnyezet.
Konzolos bemenet és kimenet.
Visual Studio vagy más C#-kompatibilis fejlesztőkörnyezet.
GitHub a forráskód tárolására.
3. A program felépítése

A program fő része a Program osztályban található. A végrehajtás a Main() metódusból indul.

A forráskód fő részei:

Névterek és osztály deklarációja.
Változók létrehozása.
Alapvető adattípusok használata.
Matematikai műveletek.
Típuskonverziók.
Feltételes elágazások.
Dinamikus változók kezelése.
4. Változók és adattípusok

A program többféle adattípust használ.

Példák a forráskódból:

csharp
int num1 = 2;
int num2 = 23;
string text = "NERO";
char alphabet = 'N';
double sum = 32.3;


Az adattípusok jelentése:

int: egész számok tárolására szolgál.
string: szöveges adatok tárolására szolgál.
char: egyetlen karakter tárolására alkalmas.
double: tizedes törteket tartalmazó számok tárolására használható.
dynamic: futás közben változtatható típusú érték tárolására alkalmas.

A programban a num1 változó értéke először 2, majd 21 lesz.

5. Matematikai műveletek

A program különböző matematikai operátorokat alkalmaz.

A használt műveletek:

+ összeadás.
- kivonás.
* szorzás.
/ osztás.
% maradékképzés.

Például:

csharp
int num3 = num1 + num2;


Ez a két változó értékét összeadja. A művelet eredménye 44.

A program később rövidített értékadó operátorokat is alkalmaz:

csharp
num1 -= 12;
num1 -= 2;
num1 *= 3;
num1 /= 2;


Ezek segítségével a változó értéke közvetlenül módosítható.

6. Típuskonverzió

A program implicit és explicit típuskonverziót is bemutat.

csharp
sum = num1;
num1 = (int)sum;


Az első sorban az egész számot a program automatikusan double típusúvá alakítja.

A második sorban explicit konverzió történik, amely során a double érték egész számmá alakul.

A tizedes rész ilyen átalakításkor elvész.

7. Inkrementáció és dekrementáció

A forráskódban megtalálható a növelő és csökkentő operátor használata.

csharp
num1++;
++num1;
num1--;
--num1;

num1++: a változó értékének növelése eggyel, postfix formában.
++num1: a változó értékének növelése eggyel, prefix formában.
num1--: a változó értékének csökkentése eggyel, postfix formában.
--num1: a változó értékének csökkentése eggyel, prefix formában.
8. Feltételes elágazás – if és else

A program az if és else utasításokkal ellenőrzi, hogy egy szám páros vagy páratlan.

csharp
if (num1 % 2 == 0)
{
    even = "Páros";
}
else
{
    even = "Páratlan";
}


A % operátor megadja az osztási maradékot.

Ha a szám kettővel osztva nulla maradékot ad, akkor páros, egyébként páratlan.

A programban a vizsgált szám értéke 10, ezért az eredmény: Páros.

9. Ternáris operátor

A program a feltételes értékadást rövidebb formában is bemutatja.

csharp
even = num1 % 2 == 0 ? "Páros" : "Nem páros";


Ez a megoldás ugyanazt a logikát valósítja meg, mint az előző if-else szerkezet.

A feltétel teljesülése esetén a „Páros”, ellenkező esetben a „Nem páros” szöveg kerül a változóba.

10. Dinamikus változó használata

A program a dynamic adattípust is bemutatja.

csharp
dynamic x = 12;

x++;

Console.WriteLine("Az x értéke: " + x);

x = "szöveg";


A változó kezdetben 12-es értéket kap.

Az inkrementáció után az értéke 13 lesz, amelyet a program kiír a konzolra.

Ezután ugyanaz a változó egy szöveges értéket kap.

11. A program várható kimenete

A jelenleg aktív utasítások végrehajtásakor a konzolon a következő eredmény jelenik meg:

text
3,14
A sum egész része: 21
22
A num1 értéke:10
Páros
Páros
Az x értéke: 13


A kimenet az aktuális forráskód alapján készült.

12. Kommentelt programrészek

A forráskódban több olyan kódrészlet található, amely jelenleg kommentként szerepel.

Ezek között találhatók:

Felhasználói adatbekérés.
Két szám szorzása.
Két szám összehasonlítása.
If-else elágazások.
Egy adott szám ellenőrzése.
Számok közötti tartomány vizsgálata.

Ezek a részek később aktiválhatók és továbbfejleszthetők.

13. A program futtatása

A program futtatásához szükséges egy megfelelő .NET fejlesztői környezet.

A futtatás lépései:

A GitHub-repozitórium letöltése vagy klónozása.
A projekt megnyitása egy C#-kompatibilis fejlesztőkörnyezetben.
A projekt lefordítása.
A konzolalkalmazás elindítása.

Terminálból, a projektmappában:

bash
dotnet run

14. Összegzés

A FirstProgram egy alapvető C# gyakorlóprojekt, amely segít megismerni a programozás legfontosabb alapfogalmait.

A fejlesztés során alkalmazásra kerültek a változók, adattípusok, matematikai operátorok, típuskonverziók és feltételes elágazások.

A projekt megfelelő alapot biztosít a C# programozási nyelv további megismeréséhez.

A későbbiekben a program továbbfejleszthető felhasználói adatbekéréssel, összetettebb feltételekkel, ciklusokkal és további matematikai műveletekkel.

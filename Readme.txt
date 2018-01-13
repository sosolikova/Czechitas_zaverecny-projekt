Popis programu:


Na co jsem hrdá:
	- Nauèila jsem se verzovat projekt v Gitu

Co mì nejvíc potrápilo:
	- Zjistit a provést serializaci dat z formátu JSON
Kde bylo nejvíce chyb:
Bylo nutné ošetøit problémy:
	- V pøípadì, že uživatel zvolil takovou kombinaci žánru a zemì, a v seznamu filmù neexistuje takový, který by splòoval obì kritéria, program spadl.
	- Vzhledem k tomu, že pracujeme s pomìrnì malým seznamem žánrù a zemí docházelo k tomu, že se náhodnì vybraly v jedné volbì 2 stejné položky (napø. USA, USA).
	- Zajistit, aby pøi zadávání volby uživatele pro opakování celého programu výbìru filmu "A" nezáleželo na tom, zda se zadá "a" èi "A"

Kde je prostor na zlepšení:
	- Ošetøit to, že po zvolení žánru se pro uživatelskou volbu nabídnou jen ty zemì, které odpovídají filmùm, jež databáze filmù obsahuje. 

Možnosti pro rozšíøení programu:
	- Zadávání nových filmù a naèítání do seznamu filmù
	- Umožnìní úpravy jednotlivých filmù

Úplné zadání:
Vytvoøte program, který uživateli doporuèí náhodný film na základì žánru a zemì pùvodu. Hotový program nahrajte do Gitu.
	- Program po spuštìní uživateli nabídne nejprve ze dvou náhodných žánrù, a poté ze dvou náhodných zemí. 
	- Na základì uživatelské volby program nabídne až tøi náhodné volby.
	- Uživatel dostane volbu celý proces zopakovat.
	- Seznam filmù ètìte ze souboru Movies.json (https://gitlab.com/VojtekZak/MoviesJson)
	- Bonus: Implementujte možnost pøidat nový film. Tento se pøidá do seznamu filmù v souboru.  

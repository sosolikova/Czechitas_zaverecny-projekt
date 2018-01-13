POPIS PROGRAMU:
Program slouží k doporuèení náhodného filmu na základì uživatelem zvoleného žánru a zemì pùvodu filmu. 
	- Program po spuštìní uživateli nabídne nejprve ze dvou náhodných žánrù, a poté ze dvou náhodných zemí.
	- Na základì uživatelské volby program nabízí tolik náhodných voleb, než si uživatel vybere.
	- Po doporuèení filmu programem dostane uživatel volbu celý proces zopakovat.
	- Seznam filmù je naèítán ze souboru Movies.json.

NA CO JSEM HRDÁ:
	- Nauèila jsem se verzovat projekt v Gitu
	- Poprala jsem s naèítáním JSON

CO MÌ NEJVÍCE POTRÁPILO:
	- Zjistit a provést serializaci dat z formátu JSON
	- Projekt byl pro mne hodnì složitý. Bylo potøeba spoustu vìcí samostatnì dostudovat a hledat pomoc.

KDE BYLO NEJVÍCE CHYB:
Bylo nutné ošetøit problémy:
	- V pøípadì, že uživatel zvolil takovou kombinaci žánru a zemì, a v seznamu filmù neexistuje takový, který by splòoval obì kritéria, program spadl.
	- Vzhledem k tomu, že pracujeme s pomìrnì malým seznamem žánrù a zemí docházelo k tomu, že se náhodnì vybraly v jedné volbì 2 stejné položky (napø. USA, USA).
	- Zajistit, aby pøi zadávání volby uživatele pro opakování celého programu výbìru filmu "A" nezáleželo na tom, zda se zadá "a" èi "A"

KDE JE PROSTOR NA ZLEPŠENÍ:
	- Ošetøit to, že po zvolení žánru se pro uživatelskou volbu nabídnou jen ty zemì, které odpovídají filmùm, jež databáze filmù obsahuje. 
	- Dle zadání má program umožnit až 3 x zmìnu náhodné volby, v mém programu je uživateli umožnìno provést tolik náhodných voleb, než si vybere (žánr nebo zemi).

MOŽNOSTI ROZŠÍØENÍ PROGRAMU:
	- Zadávání nových filmù a naèítání do seznamu filmù
	- Umožnìní úpravy jednotlivých filmù

ÚPLNÉ ZADÁNÍ ÚKOLU:
Vytvoøte program, který uživateli doporuèí náhodný film na základì žánru a zemì pùvodu. Hotový program nahrajte do Gitu.
	- Program po spuštìní uživateli nabídne nejprve ze dvou náhodných žánrù, a poté ze dvou náhodných zemí. 
	- Na základì uživatelské volby program nabídne až tøi náhodné volby.
	- Uživatel dostane volbu celý proces zopakovat.
	- Seznam filmù ètìte ze souboru Movies.json (https://gitlab.com/VojtekZak/MoviesJson)
	- Bonus: Implementujte možnost pøidat nový film. Tento se pøidá do seznamu filmù v souboru.  

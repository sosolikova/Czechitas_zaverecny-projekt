POPIS PROGRAMU:
Program slouží k doporučení náhodného filmu na základě uživatelem zvoleného žánru a země původu filmu. 
	- Program po spuštění uživateli nabídne nejprve ze dvou náhodných žánrů, a poté ze dvou náhodných zemí.
	- Na základě uživatelské volby program nabízí tolik náhodných voleb, než si uživatel vybere.
	- Po doporučení filmu programem dostane uživatel volbu celý proces zopakovat.
	- Seznam filmů je načítán ze souboru Movies.json.

NA CO JSEM HRDÁ:
	- Naučila jsem se verzovat projekt v Gitu
	- Poprala jsem s načítáním JSON

CO MĚ NEJVÍCE POTRÁPILO:
	- Zjistit a provést serializaci dat z formátu JSON
	- Projekt byl pro mne hodně složitý. Bylo potřeba spoustu věcí samostatně dostudovat a hledat pomoc.

KDE BYLO NEJVÍCE CHYB:
Bylo nutné ošetřit problémy:
	- V případě, že uživatel zvolil takovou kombinaci žánru a země, a v seznamu filmů neexistuje takový, který by splňoval obě kritéria, program spadl.
	- Vzhledem k tomu, že pracujeme s poměrně malým seznamem žánrů a zemí docházelo k tomu, že se náhodně vybraly v jedné volbě 2 stejné položky (např. USA, USA).
	- Zajistit, aby při zadávání volby uživatele pro opakování celého programu výběru filmu "A" nezáleželo na tom, zda se zadá "a" či "A".

KDE JE PROSTOR NA ZLEPŠENÍ:
	- Ošetřit to, že po zvolení žánru se pro uživatelskou volbu nabídnou jen ty země, které odpovídají filmům, jež databáze filmů obsahuje. 
	- Dle zadání má program umožnit až 3 x změnu náhodné volby, v mém programu je uživateli umožněno provést tolik náhodných voleb, než si vybere (žánr nebo zemi).

MOŽNOSTI ROZŠÍŘENÍ PROGRAMU:
	- Zadávání nových filmů a načítání do seznamu filmů
	- Umožnění úpravy jednotlivých filmů

ÚPLNÉ ZADÁNÍ ÚKOLU:
Vytvořte program, který uživateli doporučí náhodný film na základě žánru a země původu. Hotový program nahrajte do Gitu.
	- Program po spuštění uživateli nabídne nejprve ze dvou náhodných žánrů, a poté ze dvou náhodných zemí. 
	- Na základě uživatelské volby program nabídne až tři náhodné volby.
	- Uživatel dostane volbu celý proces zopakovat.
	- Seznam filmů čtěte ze souboru Movies.json (https://gitlab.com/VojtekZak/MoviesJson)
	- Bonus: Implementujte možnost přidat nový film. Tento se přidá do seznamu filmů v souboru.  

Popis programu:


Na co jsem hrd�:
	- Nau�ila jsem se verzovat projekt v Gitu

Co m� nejv�c potr�pilo:
	- Zjistit a prov�st serializaci dat z form�tu JSON
Kde bylo nejv�ce chyb:
Bylo nutn� o�et�it probl�my:
	- V p��pad�, �e u�ivatel zvolil takovou kombinaci ��nru a zem�, a v seznamu film� neexistuje takov�, kter� by spl�oval ob� krit�ria, program spadl.
	- Vzhledem k tomu, �e pracujeme s pom�rn� mal�m seznamem ��nr� a zem� doch�zelo k tomu, �e se n�hodn� vybraly v jedn� volb� 2 stejn� polo�ky (nap�. USA, USA).
	- Zajistit, aby p�i zad�v�n� volby u�ivatele pro opakov�n� cel�ho programu v�b�ru filmu "A" nez�le�elo na tom, zda se zad� "a" �i "A"

Kde je prostor na zlep�en�:
	- O�et�it to, �e po zvolen� ��nru se pro u�ivatelskou volbu nab�dnou jen ty zem�, kter� odpov�daj� film�m, je� datab�ze film� obsahuje. 

Mo�nosti pro roz���en� programu:
	- Zad�v�n� nov�ch film� a na��t�n� do seznamu film�
	- Umo�n�n� �pravy jednotliv�ch film�

�pln� zad�n�:
Vytvo�te program, kter� u�ivateli doporu�� n�hodn� film na z�klad� ��nru a zem� p�vodu. Hotov� program nahrajte do Gitu.
	- Program po spu�t�n� u�ivateli nab�dne nejprve ze dvou n�hodn�ch ��nr�, a pot� ze dvou n�hodn�ch zem�. 
	- Na z�klad� u�ivatelsk� volby program nab�dne a� t�i n�hodn� volby.
	- U�ivatel dostane volbu cel� proces zopakovat.
	- Seznam film� �t�te ze souboru Movies.json (https://gitlab.com/VojtekZak/MoviesJson)
	- Bonus: Implementujte mo�nost p�idat nov� film. Tento se p�id� do seznamu film� v souboru.  

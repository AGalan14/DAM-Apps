Enunciat del Primer Projecte.
# INFORMATITZACIÓ D’UNA CASA D’APOSTES
Curs 2023/2024

Volem tenir una **interfície gràfica** amb Java senzilla per gestionar el sorteig de la primitiva.
La primitiva estarà formada per sorteig. En concret per cada sorteig s’ha de mantenir la data del sorteig, si s’ha
realitzat o no, les apostes pel sorteig i en cas de que s’hagi realitzat la combinació guanyadora el número
complementari, i el número de reintegrament. S’haurà de permetre fer consultes estadístiques, com són la mitjana
d’apostes per sorteig, el percentatge d’encerts d’un sorteig...

Ens interessarà guardar si les apostes s’han cobrat ja o no, i en cas que no s’hagin cobrat els jugadors les podran
cobrar indicant el seu identificador d’aposta. Aquests identificadors d’aposta es generaran automàticament pel
sistema en fer una aposta, i seran únicament identificadors dins d’un sorteig donat. És a dir, una aposta s’identificarà
pel seu identificador i per la data del sorteig.

Els usuaris podran fer apostes, en les apostes figurarà la data del sorteig, per poder afegir una aposta s’haurà de
comprovar que existeixi un sorteig en la data especificada. Els diferents usuaris també podran consultar les apostes
realitzades. El sistema de pagament de les apostes no el tractarem en aquesta primera versió de l’aplicació.
L’aplicació en Java la dissenyareu en UML i implementareu les següents classes amb la documentació corresponent
generada amb el **javadoc** (si ho considereu necessari podeu dissenyar i implementar altres classes auxiliars):

a) Una **classe Combinació** per representar una combinació correcta de la primitiva. S’ha de poder crear una
combinació aleatòria, una combinació com a copia d’una altra i una combinació a partir d’una taula de 6 enters.
També s’han de poder realitzar les següents operacions:
  1. Donat un nombre enter saber si està a la combinació o no.
  2. Donada una altra combinació calcular el nombre de coincidències.
  3. Convertir una combinació en un String (cadena de caràcters) que té els nombres de la primitiva
  ordenats de més petit a més gran i separats per un espai en blanc.
  4. Per generar les combinacions aleatòries probablement es necessitarà una funció (privada) que
  tornarà cert si l’enter que passem com a paràmetre està en els nombres que ja s’han inclòs a la
  representació de la combinació que s’està generant.

b) Una **classe Aposta** per representar una aposta per un sorteig. Una aposta és crea a partir d’un identificador, la data
del sorteig per al que s’aposta, una combinació de la primitiva i un nombre de reintegrament (un número entre 0 i 9
inclosos). Les operacions que s’han de poder realitzar són:
  1. Consultar l’identificador.
  2. Consultar la combinació de la primitiva.
  3. Consultar la data del sorteig.
  4. Consultar el nombre de reintegrament.
  5. Consultar si s’ha cobrat o no.
  6. Marcar l’aposta com a cobrada.

c) Una **classe Sorteig** es crea a partir d’una data i les operacions que s’han de poder realitzar són les següents:
  1. Consultar la data del sorteig.
  2. Saber si s’ha realitzat el sorteig o no.
  3. Realitzar el sorteig, es a dir generar el resultat i eliminar totes aquelles apostes que no han
  obtingut premi. Aquesta operació ha de retornar el resultat del sorteig.
  4. Consultar el resultat del sorteig (en cas que s’hagi fet el sorteig).
  5. Afegir una aposta pel sorteig (en cas que no s’hagi fet). Una aposta s’afegeix a partir d’una
  combinació. Aquesta operació ha de retornar l’aposta amb la combinació donada, amb
  l’identificador assignat pel sorteig, la data del sorteig, el número de reintegrament generat
  aleatòriament i marcada com no cobrada.
  6. Donat l’identificador d’una aposta d’aquest sorteig saber quin premi té (6 encerts, 5 encerts més
  el complementari, 5 encerts, 4 encerts, 3 encerts o no té premi).
  7. Donat l’identificador d’una aposta d’aquest sorteig saber si té reintegrament.
  8. Donat l’identificador d’una aposta premiada i/o amb reintegrament pel sorteig cobrar-la.
  9. Donat l’identificador d’una aposta premiada i/o amb reintegrament pel sorteig saber si s’ha
  cobrat.
  10. Consultar el nombre d’apostes que s’han fet.
  11. Per a cada un dels premis, consultar el nombre d’apostes que han tingut aquest premi (en cas
  que s’hagi fet el sorteig). Han de ser diferents funcions, una per cada premi.
  12. Consultar el nombre d’apostes que han tingut reintegrament (en cas que s’hagi fet el sorteig).

d) **El resultat del sorteig** estarà format per una combinació aleatòria, un número complementari (que no pot formar
part de la combinació) i un número de reintegrament. Les operacions que s’han de poder realitzar sobre el resultat
del sorteig són:
  1. Consultar la combinació del resultat.
  2. Consultar el número complementari.
  3. Consultar el número de reintegrament.

El Joc de la primitiva s’inicialitza amb la data del primer sorteig, que és l’únic al que es pot apostar inicialment. En
el nostre cas només es celebra un sorteig setmanal. Les operacions que s’han de poder realitzar són:
  1. Realitzar el sorteig que toca. Aquesta operació ha de retornar el resultat del sorteig. Si encara
  no es pot apostar per la setmana entrant quan es celebra el sorteig s’ha de permetre apostar per la
  setmana entrant una vegada realitzat el sorteig.
  2. Saber si es pot apostar per un sorteig d’una data.
  3. Afegir sorteigs. Donada una data final permet apostar a tots el sorteigs que s’han de realitzar
  entre la data de l’últim sorteig pel que es podia apostar fins ara i la data final (la data final no té
  perquè coincidir amb la data d’un sorteig).
  4. Consultar les dates dels sorteigs als que es pot apostar.
  5. Donada la data d’un sorteig (que no s’ha realitzat i pel qual ja es pot apostar fer una aposta
  aleatòria. Aquesta operació ha de retornar l’aposta amb totes les seves dades.
  6. Donada la data d’un sorteig (que no s’ha realitzat i pel qual ja es pot apostar), i una combinació
  fer una aposta amb aquesta combinació. Aquesta operació ha de retornar l’aposta amb totes les
  seves dades.
  7. Donats l’identificador d’una aposta, la data del sorteig pel que es va fer l’aposta i la data del
  sorteig pel que es vol apostar fer una aposta per aquest darrer sorteig amb la mateixa combinació
  que s’havia fet l’aposta anterior. Aquesta operació ha de retornar l’aposta amb totes les seves
  dades.
  8. Donats l’identificador i la data d’una aposta d’un sorteig que ja s’ha realitzat saber quin premi
  té.
  9. Donats l’identificador i la data d’una aposta d’un sorteig que ja s’ha realitzat saber si té
  reintegrament.
  10. Donats l’identificador i la data d’una aposta d’un sorteig que ja s’ha realitzat i que té premi i/o
  reintegrament cobrar l’aposta.
  11. Donats l’identificador i la data d’una aposta d’un sorteig que ja s’ha realitzat i que té premi i/o
  reintegrament saber si s’ha cobrat o no.
  12. Consultar el nombre d’apostes, la quantitat d’apostes premiades amb cada un del diferents
  premis i la quantitat d’apostes amb reintegrament de tots els sorteigs que s’han realitzat (pot ser
  útil definir una classe estadística per representar el resultat d’aquesta consulta).

**Estructures de dades**
Les combinacions que es podran realitzar com a apostes els pels clients estaran formades per 6 números de l’1 al 49.
Una combinació no pot tenir números repetits. El sistema oferirà als jugadors una opció per generar automàticament
combinacions, tot i que els jugadors també podran indicar la seva combinació al sistema.

Un cop realitzat el sorteig el sistema eliminarà les apostes que no tenen premi, conservant així únicament les que
han estat premiades.

El sistema permetrà consultar si hi ha premi, a partir de la data del sorteig d’una aposta.

# CampoImpestato

**CampoImpestato** è un'applicazione desktop scritta in **C# (.NET Windows Forms)** che implementa una versione personalizzata del classico gioco **Campo Minato**.

## Funzionalità Principali

1. **Griglia Personalizzabile**  
   La dimensione della griglia e la percentuale di bombe sono configurabili dall'utente.

2. **Gioco con Timer**  
   Un timer inizia a contare automaticamente quando l'utente effettua la prima mossa.

3. **Rivelazione Celle adiacenti**  
   Quando una cella vuota (senza bombe vicine) viene rivelata, il programma apre automaticamente le celle adiacenti.

4. **Gestione delle Bandierine**  
   L'utente può aggiungere o rimuovere delle bandierine cliccando con il tasto destro del mouse.

5. **Condizione di Vittoria e Sconfitta**  
   - Vittoria: Quando tutte le celle senza bombe sono state rivelate.  
   - Sconfitta: Quando l'utente clicca su una cella contenente una bomba.

---

## Invenzioni a Piacere 🎉

Questa sezione elenca alcune funzionalità aggiuntive che rendono il gioco più interessante e completo:

1. **Replay della partita**  
   Permette di ricominciare una partita utilizzando la stessa disposizione delle bombe, ideale per riprovare dopo una sconfitta.

2. **Effetto sonoro per clic e bandierine**  
   - **Clic su una cella**: Riproduce un suono quando si scopre una cella.  
   - **Bandierina**: Riproduce un suono ogni volta che si aggiunge o rimuove una bandierina.  
   I file audio vengono caricati dalla cartella **Resources**.

3. **Import/Export file XLSX tramite Explorer**  
   - **Importa Impostazioni**: Carica configurazioni di gioco (dimensione della griglia e percentuale bombe) da un file **XML** utilizzando un dialogo di esplorazione file.  
   - **Esporta Impostazioni**: Salva le configurazioni attuali in un file **XML**.

4. **Tasto di uscita dal programma**  
   Un comodo tasto per chiudere l'applicazione, con una finestra di conferma per evitare chiusure accidentali.

5. **About - Informazioni sul programma**  
   Una finestra "About" che mostra i dettagli dell'applicazione utilizzando le informazioni dell'**Assembly Info** di Visual Studio.

---
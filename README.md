**C# Essentials -- Tussentijdse test**

**Algemene richtlijnen**

-   De tussentijdse test moet afgelegd worden op **twee uur**.

-   Gebruik deze test om de situatie te simuleren van het examen. Met
    andere woorden er mag op geen enkele manier gebruik gemaakt worden
    van het **internet,** een **gsm of externe hulp**.

**RabbitFarm**

Maak een desktoptoepassing in C# om de populatiegroei te simuleren van
een konijnen boerderij. Boeren willen de applicatie kunnen gebruiken om
te voorspellen wanneer de capaciteit van hun boerderij bereikt is.

Een boerderij kan bestaan uit velden en stallen, genaamd huizen, waarin
konijnen kunnen leven. Ieder veld heeft een capaciteit van honderd
konijnen. Ieder huis heeft een capaciteit van veertig konijnen.

![](./media/image1.emf)

***Afb 1: Startscherm - Rabbit Farm***

***\
***

***PROGRAMMEERVOORWAARDEN***

***XAML:***

Zorg er voor dat je WPF venster overeenkomt met het ontwerp zichtbaar in
de bovenstaande afbeelding. (Afb 1)

-   Het ontwerp bevat een TextBlock voor de titel van de applicatie,
    "Rabbit Farm". Deze TextBlock heeft een lettergrootte van 20.

-   Het venster heeft de kleur: LightGreen.

-   Het ontwerp bevat vier TextBlock'en en vier TextBox'en waarin de
    gebruiker vier soorten gegevens kan doorgeven: het aantal huizen,
    het aantal velden, de grootte van de initiële konijnen sprong en het
    aantal maanden.

-   Het venster heeft een grote TextBox voor de output van de applicatie
    in weer te geven. De inhoud van deze TextBox kan de gebruiker niet
    aanpassen.

-   Het ontwerp heeft drie knoppen: "Wissen", "Bereken Capaciteit" en
    "Simulatie".

***Applicatielogica*:**

**Bereken Capaciteit:**

-   Als gebruiker kan ik op de "Bereken Capaciteit"-knop klikken om de
    capaciteit van mijn boerderij te berekenen. Als gebruiker kan ik het
    resultaat van de berekening lezen in het grote resultaatveld. (Zie
    Afb 2) Elk huis heeft een capaciteit van 40 en elk veld heeft een
    capaciteit van 100.

![](./media/image2.emf)

**Afb 2: Berekening Capaciteit**

**\
**

**Bereken Capaciteit foutmelding:**

-   Als gebruiker krijg ik een foutmelding te zien in een berichtvenster
    wanneer ik op de "Bereken Capaciteit"-knop klik en ongeldige input
    ingeef. Input is ongeldig wanneer deze niet geconverteerd kan worden
    naar een integer getal. (Zie Afb 3) ○ Zorg er voor dat het
    berichtvenster een gepaste afbeelding heeft.

    -   Zorg er voor dat het berichtvenster enkel een "Ok"-knop heeft.

    -   Zorg er voor dat het berichtvenster een boodschap bevat om het
        aantal huizen of velden aan te passen.

![](./media/image3.emf)

**Afb 3: Foutmelding voor ongeldige input (Bereken Capaciteit)**

**Simulatie:**

-   Als gebruiker kan ik op de "Simulatie"-knop klikken om een
    maandelijkse simulatie te tonen van mijn boerderij in het
    resultaatveld. (Zie Afb 4)

    -   De eerste drie maanden zal de sprong niet groeien. Pas vanaf de
        vierde maand zal de konijnenpopulatie groter worden.

    -   Na de derde maand wordt de populatie iedere maand 50% groter.
        Rond telkens de populatie naar beneden af.

    -   De populatie kan nooit groter worden dan de maximale capaciteit
        van de boerderij. (Zie Afb 5)

    -   De simulatie start op maand '1' en iedere maand wordt in een
        nieuwe regel afgedrukt in het formaat: "maand {maand nummer}:
        {grootte van sprong}"

    -   Gebruik een StringBuilder om de uitvoer te bouwen.

**Simulatie foutmelding:**

-   Als gebruiker krijg ik een foutmelding te zien in een berichtvenster
    wanneer ik op de "Simulatie"-knop klik en ongeldige input ingeef.
    Input is ongeldig wanneer deze niet geconverteerd kan worden naar
    een integer getal. (Zie Afb 6)

    -   Zorg er voor dat het berichtvenster een gepaste afbeelding
        heeft.

    -   Zorg er voor dat het berichtvenster enkel een "Ok"-knop heeft.

    -   Zorg er voor dat het berichtvenster een boodschap bevat om het
        aantal huizen, velden, spronggrootte of aantal maanden aan te
        passen.

![](./media/image4.emf)

**Afb 4: Simulatie van een sprong konijnen**

![](./media/image5.emf)

**Afb 5: De groei van de sprong is gelimiteerd door de capaciteit**

![](./media/image6.emf)**Afb 6:
Foutmelding voor ongeldige input (Simulatie)**

**Wissen:**

-   Als gebruiker kan ik op de "Wissen"-knop klikken om het scherm naar
    zijn starttoestand te zetten. (Zie Afb 1)

    -   De invulvelden hebben de waarde nul.

    -   Het resultaatveld is leeg.

    -   Schrijf hier een methode voor die je oproept wanneer er op de
        "Wissen"- knop geklikt wordt. Roep deze methode ook op wanneer
        het scherm geladen wordt.

DROP TABLE Gebaeude;
DROP TABLE PKategorien;
DROP TABLE Felder;
DROP TABLE Ressourcen;


CREATE TABLE Ressourcen
(
    RID VARCHAR(3) PRIMARY KEY,
    Resourcen CHAR(30)
);

CREATE TABLE Felder
(
    FID VARCHAR(3) PRIMARY KEY,
    Feld CHAR(10)
);

CREATE TABLE PKategorien
(
    KID VARCHAR(3) PRIMARY KEY,
    Kategorie CHAR(25)
);

CREATE TABLE Gebaeude
(
    GID VARCHAR(3) PRIMARY KEY,
    Gebaeudename CHAR(30),
    Produktion VARCHAR(3) REFERENCES Ressourcen (RID),
    Tier_1 NUMBER(1),
    Tier_2 NUMBER(1),
    Tier_3 NUMBER(1),
    Produktionsrate_1 NUMBER(3),
    Produktionsrate_2 NUMBER(3),
    Produktionsrate_3 NUMBER(3),
    Produktionskosten_1 CHAR(40),
    Produktionskosten_2 CHAR(40),
    Produktionskosten_3 CHAR(40),
    Feld VARCHAR(3) REFERENCES  Felder (FID),
    Kategorie VARCHAR(3) REFERENCES PKategorien (KID)
);

INSERT INTO Ressourcen VALUES (1, 'Holz');
INSERT INTO Ressourcen VALUES (2, 'Planken');
INSERT INTO Ressourcen VALUES (3, 'Lehmziegel');
INSERT INTO Ressourcen VALUES (4, 'Stoff');
INSERT INTO Ressourcen VALUES (5, 'Steinziegel');
INSERT INTO Ressourcen VALUES (6, 'Eisenbarren');
INSERT INTO Ressourcen VALUES (7, 'Goldbarren');
INSERT INTO Ressourcen VALUES (8, 'Kupferbarren');
INSERT INTO Ressourcen VALUES (9, 'Silberbarren');
INSERT INTO Ressourcen VALUES (10, 'Glas');
INSERT INTO Ressourcen VALUES (11, 'Stahlbarren');
INSERT INTO Ressourcen VALUES (12, 'Imprägnierte Planken');
INSERT INTO Ressourcen VALUES (13, 'Leinenstoff');
INSERT INTO Ressourcen VALUES (14, 'Kohle');
INSERT INTO Ressourcen VALUES (15, 'Lehm');
INSERT INTO Ressourcen VALUES (16, 'Steine');
INSERT INTO Ressourcen VALUES (17, 'Eisenerz');
INSERT INTO Ressourcen VALUES (18, 'Kupfererz');
INSERT INTO Ressourcen VALUES (19, 'Silbererz');
INSERT INTO Ressourcen VALUES (20, 'Sand');
INSERT INTO Ressourcen VALUES (21, '�l');
INSERT INTO Ressourcen VALUES (22, 'Golderz');
INSERT INTO Ressourcen VALUES (23, 'Menschen');
INSERT INTO Ressourcen VALUES (24, 'Technologien');
INSERT INTO Ressourcen VALUES (25, 'Tier');
INSERT INTO Ressourcen VALUES (26, 'Wolle');
INSERT INTO Ressourcen VALUES (27, 'Milch');
INSERT INTO Ressourcen VALUES (28, 'Obst');
INSERT INTO Ressourcen VALUES (29, 'Gemüse');
INSERT INTO Ressourcen VALUES (30, 'Eier');
INSERT INTO Ressourcen VALUES (31, 'Lein');
INSERT INTO Ressourcen VALUES (32, 'Wasser');
INSERT INTO Ressourcen VALUES (33, 'Fische');
INSERT INTO Ressourcen VALUES (34, 'Brot');
INSERT INTO Ressourcen VALUES (35, 'Käse');
INSERT INTO Ressourcen VALUES (36, 'Fleisch');
INSERT INTO Ressourcen VALUES (37, 'Silberbesteck');
INSERT INTO Ressourcen VALUES (38, 'Luxuskleidung');
INSERT INTO Ressourcen VALUES (39, 'Schmuck');
INSERT INTO Ressourcen VALUES (40, 'Alkohol');
INSERT INTO Ressourcen VALUES (41, 'Mehl');
INSERT INTO Ressourcen VALUES (42, 'Kleidung');
INSERT INTO Ressourcen VALUES (43, 'Werkzeuge');
INSERT INTO Ressourcen VALUES (44, 'Trinkgläser');
INSERT INTO Ressourcen VALUES (45, 'Präzisionswerkzeug');
INSERT INTO Ressourcen VALUES (46, 'Getreide');

INSERT INTO Felder VALUES ( 1, 'Grassland');
INSERT INTO Felder VALUES ( 2, 'Gebirge');
INSERT INTO Felder VALUES ( 3, 'Wasser');
INSERT INTO Felder VALUES ( 4, 'Wüste');

INSERT INTO PKategorien VALUES ( 1, 'Baustoffe');
INSERT INTO PKategorien VALUES ( 2, 'Bergbau');
INSERT INTO PKategorien VALUES ( 3, 'Infrastruktur');
INSERT INTO PKategorien VALUES ( 4, 'Landwirtschaft');
INSERT INTO PKategorien VALUES ( 5, 'Lebensmittelproduktion');
INSERT INTO PKategorien VALUES ( 6, 'Luxusgüter');
INSERT INTO PKategorien VALUES ( 7, 'Verbrauchsstoff');

INSERT INTO Gebaeude VALUES ( 'G01', 'Förster', 1, 1, 1, 1, 2, 5, 10, null, null, null, 1, 1);
INSERT INTO Gebaeude VALUES ( 'G02', 'Sägewerk', 2, 1, 1, 1, 1, 3, 5, 'Holz', null, null, 1, 1);
INSERT INTO Gebaeude VALUES ( 'G03', 'Lehmziegelfabrik', 3, 1, 1, 1, 1, 3, 5, 'Lehm', 'Kohle', 'Wasser', 1,1);
INSERT INTO Gebaeude VALUES ( 'G04', 'Weberei', 4, 1, 1, 1, 1, 3, 5, 'Stoff', null, null, 1, 1);
INSERT INTO Gebaeude VALUES ( 'G05', 'Steinmetz', 5, 0, 1, 1, 1, 3, 5, 'Stein', null, null, 1, 1);
INSERT INTO Gebaeude VALUES ( 'G06', 'Eisenschmelze', 6, 0, 1, 1, 1, 3, 5, 'Eisenerz', 'Kohle', null, 1, 1);
INSERT INTO Gebaeude VALUES ( 'G07', 'Goldschmelze', 7, 0, 1, 1, 1, 3, 5, 'Golderz', 'Kohle', null, 1, 1);
INSERT INTO Gebaeude VALUES ( 'G08', 'Kupferschmelze', 8, 0, 1, 1, 1, 3, 5, 'Kupfererz', 'Kohle', null, 1, 1);
INSERT INTO Gebaeude VALUES ( 'G09', 'Silberschmelze', 9, 0, 1, 1, 1, 3, 5, 'Silbererz', 'Kohle', null, 1, 1);
INSERT INTO Gebaeude VALUES ( 'G10', 'Glaserei', 10, 0, 1, 1, 1, 3, 5, 'Sand', 'Kohle', null, 1, 1);
INSERT INTO Gebaeude VALUES ( 'G11', 'Hochofen', 11, 0, 0, 1, 1, 3, 5, 'Eisenbarren', 'Kohle', null, 1, 1);
INSERT INTO Gebaeude VALUES ( 'G12', 'Holz-Impr�gnierer', 12, 0, 0, 1, 1, 3, 5, 'Planken', '�l', null, 1, 1);
INSERT INTO Gebaeude VALUES ( 'G13', 'Kunstweberei', 13, 0, 0, 1, 1, 3, 5, 'Lein', null, null, 1, 1);
INSERT INTO Gebaeude VALUES ( 'G14', 'Kohlemine', 14, 1, 1, 1, 2, 5, 10, null, null, null, 2, 2);
INSERT INTO Gebaeude VALUES ( 'G15', 'Lehmgrube', 15, 1, 1, 1, 1, 3, 5, null, null, null, 1, 2);
INSERT INTO Gebaeude VALUES ( 'G16', 'Köhlerrei', 14, 1, 1, 1, 3, 6, 12, 'Holz', null, null, 1, 2);
INSERT INTO Gebaeude VALUES ( 'G17', 'Steinbruch', 16, 0, 1, 1, 2, 5, 10, null, null, null, 2, 2);
INSERT INTO Gebaeude VALUES ( 'G18', 'Eisenmine', 17, 0, 1, 1, 2, 5, 10, null, null, null, 2, 2);
INSERT INTO Gebaeude VALUES ( 'G19', 'Kupfermine', 18, 0, 1, 1, 2, 5, 10, null, null, null, 2, 2);
INSERT INTO Gebaeude VALUES ( 'G20', 'Silbermine', 19, 0, 1, 1, 2, 5, 10, null, null, null, 2, 2);
INSERT INTO Gebaeude VALUES ( 'G21', 'Sandgrube', 20, 0, 1, 1, 2, 5, 10, null, null, null, 4, 2);
INSERT INTO Gebaeude VALUES ( 'G22', '�l-Feld', 21, 0, 0, 1, 1, 3, 5, null, null, null, 4, 2);
INSERT INTO Gebaeude VALUES ( 'G23', 'Goldmine', 22, 0, 0, 1, 2, 5, 10, null, null, null, 2, 2);

INSERT INTO Gebaeude VALUES ( 'G24', 'Haus', 23, 1, 1, 1, 1, 3, 5, null, null, null, 1, 3);
INSERT INTO Gebaeude VALUES ( 'G25', 'Lager', null, 1, 1, 1, 1, 1, 1, null, null, null, 1, 3);
INSERT INTO Gebaeude VALUES ( 'G26', 'Markt', null, 1, 1, 1, 1, 1, 1, null, null, null, 1, 3);
INSERT INTO Gebaeude VALUES ( 'G27', 'Schule', 24, 1, 1, 1, 2, 5, 10, null, null, null, 1, 3);
INSERT INTO Gebaeude VALUES ( 'G28', 'Universität', 24, 0, 1, 1, 2, 5, 10, null, null, null, 1, 3);

INSERT INTO Gebaeude VALUES ( 'G29', 'Farm', 46, 1, 1, 1, 1, 3, 5, 'Wasser', null, null, 1, 4);
INSERT INTO Gebaeude VALUES ( 'G30', 'Tierhof', 25, 1, 1, 1, 1, 3, 5, 'Getreide', 'Wasser', null, 1, 4);
INSERT INTO Gebaeude VALUES ( 'G31', 'Schafweide', 26, 0, 1, 1, 1, 3, 5, 'Obst', 'Wasser', null, 1, 4);
INSERT INTO Gebaeude VALUES ( 'G32', 'Kuhweide', 27, 0, 1, 1, 1, 3, 5, 'Gemüse', 'Wasser', null, 1, 4);
INSERT INTO Gebaeude VALUES ( 'G33', 'Obstplantage', 28, 0, 1, 1, 2, 5, 10, 'Wasser', null, null, 1, 4);
INSERT INTO Gebaeude VALUES ( 'G34', 'Gemüseplantage', 29, 0, 1, 1, 2, 5, 10, 'Wasser', null, null, 1, 4);
INSERT INTO Gebaeude VALUES ( 'G35', 'Hühnerstall', 30, 0, 0, 1, 1, 3, 5, 'Getreide', null, null, 1, 4);
INSERT INTO Gebaeude VALUES ( 'G36', 'Flachs Farm', 31, 0, 0, 1, 1, 3, 5, 'Wasser', null, null, 1, 4);
INSERT INTO Gebaeude VALUES ( 'G37', 'Pumpenkunst', 32, 1, 1, 1, 3, 6, 12, null, null, null, 2, 5);
INSERT INTO Gebaeude VALUES ( 'G38', 'Fischer', 33, 1, 1, 1, 2, 5, 10, null, null, null, 3, 5);
INSERT INTO Gebaeude VALUES ( 'G39', 'Bäcker', 34, 1, 1, 1, 2, 5, 10, 'Mehl', 'Wasser', 'Kohle', 1, 5);
INSERT INTO Gebaeude VALUES ( 'G40', 'Käserei', 35, 0, 1, 1, 2, 5, 10, 'Milch', null, null, 1, 5);
INSERT INTO Gebaeude VALUES ( 'G41', 'Schlachter', 36, 0, 0, 1, 2, 5, 10, 'Tier', null, null, 1, 5);
INSERT INTO Gebaeude VALUES ( 'G42', 'Silberschmiede', 37, 0, 1, 1, 2, 5, 10, 'Silber', null, null, 1, 6);
INSERT INTO Gebaeude VALUES ( 'G43', 'Edelschneider', 38, 0, 0, 1, 2, 5, 10, 'Leinenstoff', null, null, 1, 6);
INSERT INTO Gebaeude VALUES ( 'G44', 'Goldschmiede', 39, 0, 0, 1, 2, 5, 10, 'Goldbarren', null, null, 1, 6);
INSERT INTO Gebaeude VALUES ( 'G45', 'Brennerei', 40, 0, 0, 1, 2, 5, 10, 'Obst', null, null, 1, 6);
INSERT INTO Gebaeude VALUES ( 'G46', 'Mühle', 41, 1, 1, 1, 2, 5, 10, 'Getreide', null, null, 1, 7);
INSERT INTO Gebaeude VALUES ( 'G47', 'Schneiderei', 42, 1, 1, 1, 2, 5, 10, 'Wolle', null, null, 1, 7);
INSERT INTO Gebaeude VALUES ( 'G48', 'Schmiede', 43, 0, 1, 1, 2, 5, 10, 'Holz', 'Eisenbarren', 'Stahlbarren', 1, 7);
INSERT INTO Gebaeude VALUES ( 'G49', 'Glasbläser', 44, 0, 1, 1, 2, 5, 10, 'Glas', 'Kohle', null, 1, 7);
INSERT INTO Gebaeude VALUES ( 'G50', 'Meister-Handwerker', 45, 0, 0, 1, 2, 5, 10, 'Stahlbarren', 'Öl', null, 1, 7);
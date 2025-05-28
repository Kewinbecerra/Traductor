Create database idiomas
go
use idiomas
go
create table Ingles(
codigo int primary key,
Palabra varchar(60) CHECK (Palabra NOT LIKE '%[^A-Za-zÁÉÍÓÚáéíóúÑñ ]%') not null
)
go
create table Frances(
codigo int primary key,
Palabra varchar(60) CHECK (Palabra NOT LIKE '%[^A-Za-zÁÉÍÓÚáéíóúÑñ ]%') not null
)
go 
create table Aleman(
codigo int primary key,
Palabra varchar(60) CHECK (Palabra NOT LIKE '%[^A-Za-zÁÉÍÓÚáéíóúÑñ ]%') not null
)
go
create table español(
codigo int primary key not null,
Palabra varchar(60) not null CHECK (Palabra NOT LIKE '%[^A-Za-zÁÉÍÓÚáéíóúÑñ ]%'),
codigoingles int, foreign key (codigoingles) references Ingles(codigo)
on update cascade
on delete set null,
codigofrances int, foreign key (codigofrances) references Frances(codigo)
on update cascade
on delete set null,
codigoaleman int, foreign key (codigoaleman) references Aleman(codigo)
on update cascade
on delete set null
)
go

INSERT INTO Ingles (codigo, Palabra) VALUES
(1, 'house'), (2, 'cat'), (3, 'book'), (4, 'car'), (5, 'tree'),
(6, 'water'), (7, 'sun'), (8, 'moon'), (9, 'dog'), (10, 'door'),
(11, 'flower'), (12, 'apple'), (13, 'river'), (14, 'mountain'), (15, 'bird'),
(16, 'school'), (17, 'chair'), (18, 'table'), (19, 'city'), (20, 'food'),
(21, 'music'), (22, 'family'), (23, 'friend'), (24, 'road'), (25, 'sky'),
(26, 'star'), (27, 'wind'), (28, 'fire'), (29, 'earth'), (30, 'love'),
(31, 'happy'), (32, 'sad'), (33, 'fast'), (34, 'slow'), (35, 'light'),
(36, 'dark'), (37, 'strong'), (38, 'weak'), (39, 'big'), (40, 'small'),
(41, 'new'), (42, 'old'), (43, 'cold'), (44, 'hot'), (45, 'rain'),
(46, 'snow'), (47, 'sea'), (48, 'fish'), (49, 'horse'), (50, 'child');

go
INSERT INTO Frances (codigo, Palabra) VALUES
(1, 'maison'), (2, 'chat'), (3, 'livre'), (4, 'voiture'), (5, 'arbre'),
(6, 'eau'), (7, 'soleil'), (8, 'lune'), (9, 'chien'), (10, 'porte'),
(11, 'fleur'), (12, 'pomme'), (13, 'riviere'), (14, 'montagne'), (15, 'oiseau'),
(16, 'école'), (17, 'chaise'), (18, 'table'), (19, 'ville'), (20, 'nourriture'),
(21, 'musique'), (22, 'famille'), (23, 'ami'), (24, 'route'), (25, 'ciel'),
(26, 'étoile'), (27, 'vent'), (28, 'feu'), (29, 'terre'), (30, 'amour'),
(31, 'heureux'), (32, 'triste'), (33, 'rapide'), (34, 'lent'), (35, 'lumiere'),
(36, 'sombre'), (37, 'fort'), (38, 'faible'), (39, 'grand'), (40, 'petit'),
(41, 'nouveau'), (42, 'vieux'), (43, 'froid'), (44, 'chaud'), (45, 'pluie'),
(46, 'neige'), (47, 'mer'), (48, 'poisson'), (49, 'cheval'), (50, 'enfant');

go
INSERT INTO Aleman (codigo, Palabra) VALUES
(1, 'Haus'), (2, 'Katze'), (3, 'Buch'), (4, 'Auto'), (5, 'Baum'),
(6, 'Wasser'), (7, 'Sonne'), (8, 'Mond'), (9, 'Hund'), (10, 'Tur'),
(11, 'Blume'), (12, 'Apfel'), (13, 'Fluss'), (14, 'Berg'), (15, 'Vogel'),
(16, 'Schule'), (17, 'Stuhl'), (18, 'Tisch'), (19, 'Stadt'), (20, 'Essen'),
(21, 'Musik'), (22, 'Familie'), (23, 'Freund'), (24, 'Strabe'), (25, 'Himmel'),
(26, 'Stern'), (27, 'Wind'), (28, 'Feuer'), (29, 'Erde'), (30, 'Liebe'),
(31, 'glucklich'), (32, 'traurig'), (33, 'schnell'), (34, 'langsam'), (35, 'Licht'),
(36, 'dunkel'), (37, 'stark'), (38, 'schwach'), (39, 'grob'), (40, 'klein'),
(41, 'neu'), (42, 'alt'), (43, 'kalt'), (44, 'heib'), (45, 'Regen'),
(46, 'Schnee'), (47, 'Meer'), (48, 'Fisch'), (49, 'Pferd'), (50, 'Kind');

go
INSERT INTO español (codigo, Palabra, codigoingles, codigofrances, codigoaleman) VALUES
(1, 'casa', 1, 1, 1),(2, 'gato', 2, 2, 2),(3, 'libro', 3, 3, 3),
(4, 'coche', 4, 4, 4),(5, 'árbol', 5, 5, 5),(6, 'agua', 6, 6, 6),
(7, 'sol', 7, 7, 7),(8, 'luna', 8, 8, 8),(9, 'perro', 9, 9, 9),
(10, 'puerta', 10, 10, 10),(11, 'flor', 11, 11, 11),(12, 'manzana', 12, 12, 12),
(13, 'río', 13, 13, 13),(14, 'montaña', 14, 14, 14),(15, 'pájaro', 15, 15, 15),
(16, 'escuela', 16, 16, 16),(17, 'silla', 17, 17, 17),(18, 'mesa', 18, 18, 18),
(19, 'ciudad', 19, 19, 19),(20, 'comida', 20, 20, 20),(21, 'música', 21, 21, 21),
(22, 'familia', 22, 22, 22),(23, 'amigo', 23, 23, 23),(24, 'carretera', 24, 24, 24),
(25, 'cielo', 25, 25, 25),(26, 'estrella', 26, 26, 26),(27, 'viento', 27, 27, 27),
(28, 'fuego', 28, 28, 28),(29, 'tierra', 29, 29, 29),(30, 'amor', 30, 30, 30),
(31, 'feliz', 31, 31, 31),(32, 'triste', 32, 32, 32),(33, 'rápido', 33, 33, 33),
(34, 'lento', 34, 34, 34),(35, 'luz', 35, 35, 35),(36, 'oscuro', 36, 36, 36),
(37, 'fuerte', 37, 37, 37),(38, 'débil', 38, 38, 38),(39, 'grande', 39, 39, 39),
(40, 'pequeño', 40, 40, 40),(41, 'nuevo', 41, 41, 41),(42, 'viejo', 42, 42, 42),
(43, 'frío', 43, 43, 43),(44, 'caliente', 44, 44, 44),(45, 'lluvia', 45, 45, 45),
(46, 'nieve', 46, 46, 46),(47, 'mar', 47, 47, 47),(48, 'pez', 48, 48, 48),
(49, 'caballo', 49, 49, 49),(50, 'niño', 50, 50, 50);

go
INSERT INTO español (codigo, Palabra, codigoingles, codigofrances, codigoaleman) VALUES
(51, 'hogar', 1, 1, 1),(52, 'vivienda', 1, 1, 1),(53, 'felino', 2, 2, 2),
(54, 'tomo', 3, 3, 3),(55, 'volumen', 3, 3, 3),(56, 'auto', 4, 4, 4),
(57, 'vehículo', 4, 4, 4),(58, 'planta', 5, 5, 5),(59, 'árbolito', 5, 5, 5),
(60, 'líquido', 6, 6, 6),(61, 'florecita', 11, 11, 11),(62, 'manzanita', 12, 12, 12),
(63, 'corriente', 13, 13, 13),(64, 'cerro', 14, 14, 14),(65, 'ave', 15, 15, 15),(66, 'colegio', 16, 16, 16),(67, 'butaca', 17, 17, 17),
(68, 'tablero', 18, 18, 18),(69, 'metrópoli', 19, 19, 19),(70, 'alimento', 20, 20, 20),
(71, 'melodía', 21, 21, 21),(72, 'parentesco', 22, 22, 22),(73, 'compañero', 23, 23, 23),
(74, 'avenida', 24, 24, 24),(75, 'firmamento', 25, 25, 25),(76, 'lucero', 26, 26, 26),
(77, 'brisa', 27, 27, 27),(78, 'llama', 28, 28, 28),(79, 'mundo', 29, 29, 29),
(80, 'cariño', 30, 30, 30),(81, 'contento', 31, 31, 31),(82, 'melancólico', 32, 32, 32),(83, 'veloz', 33, 33, 33),
(84, 'pausado', 34, 34, 34),(85, 'claridad', 35, 35, 35),(86, 'tenebroso', 36, 36, 36),
(87, 'robusto', 37, 37, 37),(88, 'frágil', 38, 38, 38),(89, 'enorme', 39, 39, 39),(90, 'diminuto', 40, 40, 40),
(91, 'reciente', 41, 41, 41),(92, 'antiguo', 42, 42, 42),(93, 'helado', 43, 43, 43),
(94, 'abrasador', 44, 44, 44),(95, 'chaparrón', 45, 45, 45),(96, 'ventisca', 46, 46, 46),
(97, 'océano', 47, 47, 47),(98, 'pez pequeño', 48, 48, 48),(99, 'equino', 49, 49, 49),
(100, 'infante', 50, 50, 50);
go
CREATE VIEW vista_Traducciones AS
SELECT 
    e.Palabra ,
    i.Palabra ,
    f.Palabra ,
    a.Palabra 
FROM 
    español as e
JOIN 
    Ingles as i ON e.codigoingles = i.codigo
JOIN 
    Frances as f ON e.codigofrances = f.codigo
JOIN 
    Aleman  as a ON e.codigoaleman = a.codigo;
GO
update español
set codigo = 1
where Palabra = 'casa'



select * from vista_Traducciones
select * From Aleman

use master
drop database idiomas
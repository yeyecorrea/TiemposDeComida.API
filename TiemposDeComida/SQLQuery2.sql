INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp])
VALUES 
('1', 'Admin', 'ADMIN', NEWID()),
('2', 'Restaurante', 'RESTAURANTE', NEWID()),
('3', 'Usuario', 'USUARIO', NEWID());

-- Tabla de Usuarios de Perfil
INSERT INTO [dbo].[ProfileUsers] ([Name], [Cities], [Bio], [PhotoProfileUrl], [DateRegistration])
VALUES
('Juan Pérez', 'Bogotá, Medellín', 'Amante de la gastronomía local', 'https://example.com/profiles/juan.jpg', GETDATE()),
('María Gómez', 'Cali', 'Crítica gastronómica profesional', 'https://example.com/profiles/maria.jpg', GETDATE()),
('Carlos Rojas', 'Bogotá', 'Foodie y viajero', 'https://example.com/profiles/carlos.jpg', GETDATE()),
('Ana López', 'Medellín', 'Chef amateur', 'https://example.com/profiles/ana.jpg', GETDATE()),
('Admin User', NULL, 'Administrador del sistema', 'https://example.com/profiles/admin.jpg', GETDATE());

-- Tabla de Usuarios
INSERT INTO [dbo].[AspNetUsers] ([Id], [ProfileUserId], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount])
VALUES
('1', 1, 'juan@example.com', 'JUAN@EXAMPLE.COM', 'juan@example.com', 'JUAN@EXAMPLE.COM', 1, 'AQAAAAEAACcQAAAAEHy6r6F3vJgX5wZ...', NEWID(), NEWID(), '3101234567', 1, 0, NULL, 1, 0),
('2', 2, 'maria@example.com', 'MARIA@EXAMPLE.COM', 'maria@example.com', 'MARIA@EXAMPLE.COM', 1, 'AQAAAAEAACcQAAAAEHy6r6F3vJgX5wZ...', NEWID(), NEWID(), '3102345678', 1, 0, NULL, 1, 0),
('3', 3, 'carlos@example.com', 'CARLOS@EXAMPLE.COM', 'carlos@example.com', 'CARLOS@EXAMPLE.COM', 1, 'AQAAAAEAACcQAAAAEHy6r6F3vJgX5wZ...', NEWID(), NEWID(), '3103456789', 1, 0, NULL, 1, 0),
('4', 4, 'ana@example.com', 'ANA@EXAMPLE.COM', 'ana@example.com', 'ANA@EXAMPLE.COM', 1, 'AQAAAAEAACcQAAAAEHy6r6F3vJgX5wZ...', NEWID(), NEWID(), '3104567890', 1, 0, NULL, 1, 0),
('5', 5, 'admin@example.com', 'ADMIN@EXAMPLE.COM', 'admin@example.com', 'ADMIN@EXAMPLE.COM', 1, 'AQAAAAEAACcQAAAAEHy6r6F3vJgX5wZ...', NEWID(), NEWID(), '3105678901', 1, 0, NULL, 1, 0);

-- Asignación de Roles
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId])
VALUES
('1', '3'),
('2', '3'),
('3', '3'),
('4', '2'),
('5', '1');

-- Tipos de Establecimiento
INSERT INTO [dbo].[EstablishmentTypes] ([Name])
VALUES 
('Restaurante'),
('Cafetería'),
('Bar'),
('Food Truck'),
('Panadería');

-- Métodos de Reserva
INSERT INTO [dbo].[ReservationMethods] ([Name])
VALUES 
('Sistema en línea'),
('Llamada telefónica'),
('Aplicación móvil'),
('WhatsApp'),
('Presencial');

-- Categorías de Restaurante
INSERT INTO [dbo].[RestaurantCategorys] ([Name])
VALUES 
('Gourmet'),
('Tradicional'),
('Rápida'),
('Vegetariano'),
('Internacional');

-- Características de Restaurantes
INSERT INTO [dbo].[FeatureRestaurants] ([Name])
VALUES 
('Terraza'),
('Wifi gratis'),
('Aire acondicionado'),
('Estacionamiento'),
('Accesible'),
('Menú infantil'),
('Bar completo'),
('Música en vivo');

-- Tipos de Cocina
INSERT INTO [dbo].[TypeKitchens] ([Name])
VALUES 
('Colombiana'),
('Italiana'),
('Mexicana'),
('Japonesa'),
('Mediterránea'),
('Argentina'),
('Americana'),
('Fusión');

-- Tipos de Comida
INSERT INTO [dbo].[TypeFood] ([Name])
VALUES 
('Parrilla'),
('Pasta'),
('Sushi'),
('Ensaladas'),
('Postres'),
('Mariscos'),
('Vegana'),
('Carnes');

-- Categorías de Menú
INSERT INTO [dbo].[MenuCategoris] ([Name])
VALUES 
('Entradas'),
('Platos principales'),
('Postres'),
('Bebidas'),
('Acompañamientos'),
('Especiales del chef'),
('Menú infantil')

-- Restaurantes
INSERT INTO [dbo].[Restaurants] ([Name], [RestaurantCategoryId], [Cities], [Address], [Description], [WebPage], [Phone], [ReservationMethodId], [Latitude], [Length], [Schedules], [ApplicationUserId], [ApplicationUserId1], [EstablishmentTypeId])
VALUES
('El Fogón de los Sabores', 2, 'Bogotá', 'Calle 123 #45-67', 'Restaurante tradicional colombiano con los mejores platos de la región', 'http://elfogon.com', '6012345678', 1, 4.7110, -74.0721, 'Lunes a Viernes: 11am-10pm, Sábado y Domingo: 12pm-11pm', 4, '4', 1),
('La Pasta Divina', 1, 'Medellín', 'Carrera 56 #12-34', 'Auténtica cocina italiana con ingredientes importados', 'http://lapastadivina.com', '6045678901', 2, 6.2442, -75.5812, 'Todos los días: 12pm-11pm', 4, '4', 1),
('Sakura Sushi Bar', 5, 'Cali', 'Avenida 8 #23-45', 'Sushi fresco preparado por chefs japoneses', 'http://sakurasushi.com', '6023456789', 3, 3.4516, -76.5320, 'Martes a Domingo: 12pm-10pm', 4, '4', 1),
('Green Life', 4, 'Bogotá', 'Calle 67 #12-34', 'Cocina vegetariana y vegana con opciones saludables', NULL, '6019876543', 4, 4.6531, -74.0556, 'Lunes a Sábado: 8am-9pm', 4, '4', 1),
('La Parrilla Argentina', 1, 'Medellín', 'Carrera 34 #56-78', 'Carnes premium asadas al estilo argentino', 'http://parrillaargentina.com', '6048765432', 1, 6.2088, -75.5667, 'Martes a Domingo: 12pm-11pm', 4, '4', 1);

-- Relación Restaurante-Características
INSERT INTO [dbo].[RestaurantFeatures] ([RestaurantId], [FeatureRestaurantId])
VALUES
(1, 1), (1, 2), (1, 3),
(2, 2), (2, 3), (2, 7),
(3, 1), (3, 2), (3, 3), (3, 5),
(4, 1), (4, 2), (4, 5),
(5, 1), (5, 2), (5, 3), (5, 7);

-- Relación Restaurante-TipoCocina
INSERT INTO [dbo].[RestaurantTypeKitchens] ([RestaurantId], [TypeKitchenId])
VALUES
(1, 1),
(2, 2),
(3, 4),
(4, 5),
(5, 6);

INSERT INTO [dbo].[RestaurantTypeFoods] ([RestaurantId], [TypeFoodId])
VALUES
(1, 8), (1, 1),
(2, 2), (2, 8),
(3, 3), (3, 6),
(4, 4), (4, 7),
(5, 1), (5, 8);

-- Fotos de Restaurantes
INSERT INTO [dbo].[PhotoRestaurants] ([Url], [RestaurantId])
VALUES
('https://example.com/restaurants/fogon1.jpg', 1),
('https://example.com/restaurants/fogon2.jpg', 1),
('https://example.com/restaurants/pasta1.jpg', 2),
('https://example.com/restaurants/pasta2.jpg', 2),
('https://example.com/restaurants/sushi1.jpg', 3),
('https://example.com/restaurants/sushi2.jpg', 3),
('https://example.com/restaurants/green1.jpg', 4),
('https://example.com/restaurants/green2.jpg', 4),
('https://example.com/restaurants/parrilla1.jpg', 5),
('https://example.com/restaurants/parrilla2.jpg', 5);

-- Menú para El Fogón de los Sabores
INSERT INTO [dbo].[MenuItems] ([RestaurantId], [Name], [Description], [Price], [UpdateDate], [MenuCategoryId])
VALUES
(1, 'Bandeja Paisa', 'Plato tradicional con frijoles, arroz, chicharrón, carne molida, chorizo, aguacate, arepa y huevo', 25000, GETDATE(), 2),
(1, 'Ajiaco Santafereño', 'Sopa típica bogotana con pollo, papa criolla, papa pastusa, guascas y crema de leche', 18000, GETDATE(), 1),
(1, 'Lechona Tolimense', 'Cerdo relleno con arroz y garbanzos, cocinado a fuego lento por 12 horas', 28000, GETDATE(), 2),
(1, 'Postre de Natas', 'Postre tradicional colombiano hecho con natas de leche y panela', 8000, GETDATE(), 3);

-- Menú para La Pasta Divina
INSERT INTO [dbo].[MenuItems] ([RestaurantId], [Name], [Description], [Price], [UpdateDate], [MenuCategoryId])
VALUES
(2, 'Spaghetti Carbonara', 'Pasta con salsa cremosa de huevo, queso parmesano, panceta y pimienta negra', 22000, GETDATE(), 2),
(2, 'Lasagna Bolognesa', 'Capas de pasta con carne molida, salsa de tomate y queso gratinado', 26000, GETDATE(), 2),
(2, 'Risotto de Champiñones', 'Arroz arbóreo cocinado con caldo de vegetales, champiñones y queso parmesano', 24000, GETDATE(), 2),
(2, 'Tiramisú', 'Postre italiano con capas de bizcocho empapado en café y crema de mascarpone', 12000, GETDATE(), 3);

-- Menú para Sakura Sushi Bar
INSERT INTO [dbo].[MenuItems] ([RestaurantId], [Name], [Description], [Price], [UpdateDate], [MenuCategoryId])
VALUES
(3, 'Roll Filadelfia', 'Roll de salmón, queso crema y pepino', 28000, GETDATE(), 2),
(3, 'Sashimi Mixto', 'Selección de pescados frescos en finas láminas', 35000, GETDATE(), 2),
(3, 'Tempura de Camarón', 'Camarones rebozados en masa tempura y fritos', 22000, GETDATE(), 1),
(3, 'Mochi de Matcha', 'Postre japonés de arroz con relleno de helado de té verde', 10000, GETDATE(), 3);

-- Opiniones
INSERT INTO [dbo].[Opiniones] ([ApplicationUserId], [RestaurantId], [Title], [Description], [Calification], [DateVisitMonth], [WhoDidYouGoWith], [PublicationDate], [ApplicationUserId1], [ProfileUserId])
VALUES
(1, 1, 'Auténtica comida colombiana', 'La bandeja paisa estaba deliciosa y muy bien servida. Ambiente acogedor.', 5, 'Abril', 'Familia', GETDATE(), '1', 1),
(2, 1, 'Buen servicio', 'El ajiaco estaba perfecto, aunque la atención fue un poco lenta.', 4, 'Marzo', 'Amigos', GETDATE(), '2', 2),
(3, 2, 'Excelente pasta', 'El risotto de champiñones es lo mejor que he probado. Volveré seguro.', 5, 'Febrero', 'Pareja', GETDATE(), '3', 3),
(1, 3, 'Sushi fresco', 'El sashimi estaba muy fresco y el servicio impecable.', 5, 'Enero', 'Solo', GETDATE(), '1', 1),
(2, 4, 'Opción saludable', 'Buena variedad de opciones veganas, aunque un poco caro.', 3, 'Diciembre', 'Compañeros de trabajo', GETDATE(), '2', 2);

-- Fotos de Opiniones
INSERT INTO [dbo].[PhotoOpinions] ([Url], [OpinionId])
VALUES
('https://example.com/opinions/opinion1-1.jpg', 1),
('https://example.com/opinions/opinion1-2.jpg', 1),
('https://example.com/opinions/opinion2-1.jpg', 2),
('https://example.com/opinions/opinion3-1.jpg', 3),
('https://example.com/opinions/opinion4-1.jpg', 4),
('https://example.com/opinions/opinion5-1.jpg', 5);

-- Respuestas a Opiniones
INSERT INTO [dbo].[ResponseOpinions] ([OpinionId], [RestaurantId], [Description], [Date])
VALUES
(1, 1, 'Gracias por tu comentario, Juan. Nos alegra que hayas disfrutado nuestra bandeja paisa. ¡Esperamos verte pronto de nuevo!', GETDATE()),
(3, 2, 'Gracias Carlos, nuestro chef estará encantado de saber que disfrutaste su risotto. ¡Te esperamos para probar otros platos de nuestro menú!', GETDATE());

-- Reservas
INSERT INTO [dbo].[Bookings] ([RestaurantId], [ApplicationUserId], [NumberOfPeople], [TimeDate], [Name], [LastName], [Phone], [Email], [SpecialRequests], [bookingStatus], [ApplicationUserId1], [ProfileUserId])
VALUES
(1, 1, 4, DATEADD(DAY, 7, GETDATE()), 'Juan', 'Pérez', '3101234567', 'juan@example.com', 'Mesa cerca de la ventana, por favor', 1, '1', 1),
(2, 2, 2, DATEADD(DAY, 5, GETDATE()), 'María', 'Gómez', '3102345678', 'maria@example.com', 'Celebración de aniversario', 1, '2', 2),
(3, 3, 6, DATEADD(DAY, 3, GETDATE()), 'Carlos', 'Rojas', '3103456789', 'carlos@example.com', 'Alergia a los mariscos en el grupo', 1, '3', 3),
(4, 1, 2, DATEADD(DAY, 10, GETDATE()), 'Juan', 'Pérez', '3101234567', 'juan@example.com', NULL, 0, '1', 1);

-- Fotos de Usuarios
INSERT INTO [dbo].[PhotoUsers] ([Url], [ProfileUseId], [ProfileUserId])
VALUES
('https://example.com/userphotos/juan1.jpg', 1, 1),
('https://example.com/userphotos/juan2.jpg', 1, 1),
('https://example.com/userphotos/maria1.jpg', 2, 2),
('https://example.com/userphotos/carlos1.jpg', 3, 3),
('https://example.com/userphotos/ana1.jpg', 4, 4);
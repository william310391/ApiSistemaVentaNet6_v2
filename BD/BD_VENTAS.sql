USE [Ventas]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 18/09/2022 00:07:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[ApellidoPaterno] [varchar](150) NULL,
	[ApallidoMaterno] [varchar](150) NULL,
	[RazonSocial] [varchar](250) NULL,
	[IdTipoDocumento] [int] NULL,
	[NumeroDocumento] [varchar](15) NULL,
	[FechaNacimiento] [datetime] NULL,
	[IndActivo] [bit] NULL,
	[IdUsuarioRegistro] [int] NULL,
	[FechaRegistro] [datetime] NULL,
	[IdUsuarioModificacion] [int] NULL,
	[FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 18/09/2022 00:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[IdPedido] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[CodigoPedido] [varchar](15) NULL,
	[MontoSubTotal] [decimal](18, 2) NULL,
	[MontoIGV] [decimal](18, 2) NULL,
	[MontoTotal] [decimal](18, 2) NULL,
	[Descripcion] [varchar](500) NULL,
	[EstadoPedido] [varchar](50) NULL,
	[IndActivo] [bit] NULL,
	[IdUsuarioRegistro] [int] NULL,
	[FechaRegistro] [datetime] NULL,
	[IdUsuarioModificacion] [int] NULL,
	[FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PedidoDetalle]    Script Date: 18/09/2022 00:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PedidoDetalle](
	[IdPedidoDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdPedido] [int] NULL,
	[IdProducto] [int] NULL,
	[Cantidad] [int] NULL,
	[MontoUnitario] [decimal](17, 0) NULL,
	[MontoSubTotal] [decimal](17, 2) NULL,
	[MontoIGV] [decimal](17, 2) NULL,
	[MontoTotal] [decimal](17, 2) NULL,
	[IndActivo] [bit] NULL,
	[IdUsuarioRegistro] [int] NULL,
	[FechaRegistro] [datetime] NULL,
	[IdUsuarioModificacion] [int] NULL,
	[FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_PedidoDetalle] PRIMARY KEY CLUSTERED 
(
	[IdPedidoDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 18/09/2022 00:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[CodigoProducto] [varchar](15) NULL,
	[NombreProducto] [varchar](150) NULL,
	[Descripcion] [varchar](250) NULL,
	[Imagen] [varchar](250) NULL,
	[IndActivo] [bit] NULL,
	[IdUsuarioRegistro] [int] NULL,
	[FechaRegistro] [datetime] NULL,
	[IdUsuarioModificacion] [int] NULL,
	[FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seguridad]    Script Date: 18/09/2022 00:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seguridad](
	[IdSeguridad] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[NombreUsuario] [varchar](100) NULL,
	[Contrasena] [varchar](200) NULL,
	[Rol] [varchar](15) NULL,
	[IndActivo] [bit] NULL,
	[IdUsuarioRegistro] [int] NULL,
	[FechaRegistro] [datetime] NULL,
	[IdUsuarioModificacion] [int] NULL,
	[FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Seguridad] PRIMARY KEY CLUSTERED 
(
	[IdSeguridad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 18/09/2022 00:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Cuenta] [varchar](150) NULL,
	[Contrasena] [varchar](200) NULL,
	[NombreUsuario] [varchar](250) NULL,
	[IdRol] [int] NULL,
	[IndActivo] [bit] NULL,
	[IdUsuarioRegistro] [int] NULL,
	[FechaRegistro] [datetime] NULL,
	[IdUsuarioModificacion] [int] NULL,
	[FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((1)) FOR [IndActivo]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [IdUsuarioRegistro]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [IdUsuarioModificacion]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (getdate()) FOR [FechaModificacion]
GO
ALTER TABLE [dbo].[Seguridad] ADD  CONSTRAINT [DF_Seguridad_IndActivo]  DEFAULT ((1)) FOR [IndActivo]
GO
ALTER TABLE [dbo].[Seguridad] ADD  CONSTRAINT [DF_Seguridad_IdUsuarioRegistro]  DEFAULT ((0)) FOR [IdUsuarioRegistro]
GO
ALTER TABLE [dbo].[Seguridad] ADD  CONSTRAINT [DF_Seguridad_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[Seguridad] ADD  CONSTRAINT [DF_Seguridad_IdUsuarioModificacion]  DEFAULT ((0)) FOR [IdUsuarioModificacion]
GO
ALTER TABLE [dbo].[Seguridad] ADD  CONSTRAINT [DF_Seguridad_FechaModificacion]  DEFAULT (getdate()) FOR [FechaModificacion]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_IndActivo]  DEFAULT ((1)) FOR [IndActivo]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_IdUsuarioRegistro]  DEFAULT ((0)) FOR [IdUsuarioRegistro]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_IdUsuarioModificacion]  DEFAULT ((0)) FOR [IdUsuarioModificacion]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_FechaModificacion]  DEFAULT (getdate()) FOR [FechaModificacion]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Cliente1] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Cliente1]
GO
ALTER TABLE [dbo].[PedidoDetalle]  WITH CHECK ADD  CONSTRAINT [FK_PedidoDetalle_Pedido] FOREIGN KEY([IdPedido])
REFERENCES [dbo].[Pedido] ([IdPedido])
GO
ALTER TABLE [dbo].[PedidoDetalle] CHECK CONSTRAINT [FK_PedidoDetalle_Pedido]
GO
ALTER TABLE [dbo].[PedidoDetalle]  WITH CHECK ADD  CONSTRAINT [FK_PedidoDetalle_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[PedidoDetalle] CHECK CONSTRAINT [FK_PedidoDetalle_Producto]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetLoginByCredentialsSeguridad]    Script Date: 18/09/2022 00:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_GetLoginByCredentialsSeguridad]
@Usuario varchar(250)
as
select IdSeguridad
      ,Usuario
	  ,NombreUsuario
	  ,Contrasena
	  ,Rol
	  ,IndActivo
	  ,IdUsuarioRegistro
	  ,FechaRegistro
	  ,IdUsuarioModificacion
	  ,FechaModificacion 
from Seguridad

where Usuario=@Usuario
GO
/****** Object:  StoredProcedure [dbo].[sp_GetLoginByCredentialsUsuario]    Script Date: 18/09/2022 00:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_GetLoginByCredentialsUsuario]
@Usuario varchar(250)
as
select 
 IdUsuario
,Cuenta
,Contrasena
,NombreUsuario	
,IdRol	
,IndActivo	
,IdUsuarioRegistro	
,FechaRegistro	
,IdUsuarioModificacion	
,FechaModificacion

from Usuario

where Cuenta=@Usuario



GO
/****** Object:  StoredProcedure [dbo].[sp_GetProductoByUsuario]    Script Date: 18/09/2022 00:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_GetProductoByUsuario]
@IdUsuarioRegistro int
as
select IdProducto
      ,CodigoProducto
	  ,NombreProducto
	  ,Descripcion
	  ,Imagen
	  ,IndActivo
	  ,IdUsuarioRegistro
	  ,FechaRegistro
	  ,IdUsuarioModificacion
	  ,FechaModificacion 
from Producto
where IdUsuarioRegistro=@IdUsuarioRegistro
GO
/****** Object:  StoredProcedure [dbo].[sp_GetProductosByFilters]    Script Date: 18/09/2022 00:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetProductosByFilters]
 @IdUsuarioRegistro int =null
,@FechaRegistro date=null
,@Descripcion varchar(250)=null
as
select IdProducto
      ,CodigoProducto
	  ,NombreProducto
	  ,Descripcion
	  ,Imagen
	  ,IndActivo
	  ,IdUsuarioRegistro
	  ,FechaRegistro
	  ,IdUsuarioModificacion
	  ,FechaModificacion 
from Producto
where IdUsuarioRegistro= (case when @IdUsuarioRegistro is null then IdUsuarioRegistro else @IdUsuarioRegistro end)
  and CAST(FechaRegistro as date)=(case when @FechaRegistro is null then CAST(FechaRegistro as date) else @FechaRegistro end)
  and LOWER(Descripcion) like '%'+lower(case when @Descripcion is null then Descripcion else @Descripcion end)+'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_cliente]    Script Date: 18/09/2022 00:07:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_listar_cliente]
as
select * from cliente
GO

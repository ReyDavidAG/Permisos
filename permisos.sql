create table permisos(
idpermiso int primary key auto_increment,
lectura bool,
escritura bool,
eliminacion bool,
actualizacion bool,
fkidusuario int,
foreign key(fkidusuario) references usuarios(idusuario)  
);

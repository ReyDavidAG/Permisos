create table permisos(
idpermiso int primary key auto_increment,
lectura boolean,
escritura boolean,
eliminacion boolean,
actualizacion boolean,
fkidusuario int,
foreign key(fkidusuario) references usuarios(idusuario)  
);

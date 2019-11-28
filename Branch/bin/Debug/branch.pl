materia('Fundamentos de Programacion',semestre1).
materia('Matematicas Discretas',semestre1).

materia('POO', semestre2).

materia('Estructuctura de datos',semestre3).
materia('Sistemas Operativos', semestre3).

materia('Topicos Avanzados De Programacion', semestre4).
materia('Fundamentos de Base de Datos',semestre4).
materia('Taller De Sistemas Operativos', semestre4).

materia('Fundamentos De Telecomunicaciones',semestre5).
materia('Taller de Base de Datos',semestre5).
materia('Arquitectura de Computadoras',semestre5).
materia('Fundamentos De Ingenieria De Software', semestre5).

materia('Lenguajes Y Automatas 1',semestre6).
materia('Redes De Computadoras', semestre6).
materia('Administracion De Base de Datos',semestre6).
materia('Graficacion',semestre6).
materia('Ingenieria De Software',semestre6).
materia('Lenguajes De Interfaz',semestre6).
materia('Taller de investigacion 1',semestre6).

materia('Lenguajes y automatas 2',semestre7).
materia('Conmutacion de Redes',semestre7).
materia('Taller de investigacion 2',semestre7).
materia('Gestion de proyectos de software',semestre7).
materia('Programacion de base de datos',semestre7).
materia('Programacion logica y funcional',semestre7).
materia('Programacion web',semestre7).

materia('Sistemas Programables', semestre8).
materia('Administracion de Redes', semestre8).
materia('Admnistracion de Servidores', semestre8).

materia('Inteligencia Artificial', semestre9).
materia('Base de datos moviles', semestre9).
%afinidad(A,B,C,D,E,F,G,H,Y):-materia()

%area(Taller_de_investigacion_1,Taller_de_investigacion_2).

area(redes,'Sistemas Operativos').
area(redes,'Taller De Sistemas Operativos').
area(redes,'Fundamentos De Telecomunicaciones').
area(redes,'Arquitectura de Computadoras').
area(redes,'Redes De Computadoras').
area(redes,'Conmutación de Redes').
area(redes,'Administracion de Redes').
area(redes,'Admnistracion de Servidores').

area(administrador_de_base_de_datos,'Matematicas Discretas').
area(administrador_de_base_de_datos,'POO').
area(administrador_de_base_de_datos,'Sistemas Operativos').
area(administrador_de_base_de_datos,'Fundamentos de Base de Datos').
area(administrador_de_base_de_datos,'Taller de Base de Datos').
area(administrador_de_base_de_datos,'Administracion De Base de Datos').
area(administrador_de_base_de_datos,'Programacion de base de datos').
area(administrador_de_base_de_datos,'Base de datos moviles').

area(analista,'Fundamentos De Ingenieria De Software').
area(analista,'Ingenieria De Software').
area(analista,'Gestion de proyectos de software').
area(analista,'Taller de investigacion 1').
area(analista,'Taller de investigacion 2').
area(analista,'Matematicas Discretas').
area(analista,'Fundamentos de Programacion').
area(analista,'Fundamentos de Base de Datos').



area(backend,'POO').
area(backend,'Estructuctura de datos').
area(backend,'Topicos Avanzados De Programacion').
area(backend,'Lenguajes Y Automatas 1').
area(backend,'Lenguajes y automatas 2').
area(backend,'Fundamentos de Base de Datos').
area(backend,'Base de datos moviles').
area(backend,'Taller de investigacion 1').
area(backend,'Taller de investigacion 2').

area(frontend,'Matematicas Discretas').
area(frontend,'Graficacion').
area(frontend,'Sistemas Operativos').
area(frontend,'Taller De Sistemas Operativos').
area(frontend,'Fundamentos De Ingenieria De Software').
area(frontend,'Ingenieria De Software').
area(frontend,'Gestion de proyectos de software').
area(frontend,'Taller de investigacion 1').
area(frontend,'Taller de investigacion 2').

area(calidad,'Fundamentos de Programacion').
area(calidad,'Sistemas Operativos').
area(calidad,'Taller De Sistemas Operativos').
area(calidad,'Topicos Avanzados De Programacion').
area(calidad,'Fundamentos De Ingenieria De Software').
area(calidad,'Ingenieria De Software').
area(calidad,'Taller de investigacion 1').
area(calidad,'Taller de investigacion 2').

locacion(A,B,C):-area(A,B),materia(B,C).

materias(A,B):-materia(B,A).

perteneces(A,X):-area(X,A).

%quien_gana(A,B):-materia(B,A).
quien_gana(A,B):-materia(A,B).


%perteneces('Fundamentos de Programacion','Taller de investigacion 2','Estructuctura de datos','POO','Topicos Avanzados De Programacion','Fundamentos De Telecomunicaciones','Graficacion','Conmutación de Redes','X').
%juego de comparacion.

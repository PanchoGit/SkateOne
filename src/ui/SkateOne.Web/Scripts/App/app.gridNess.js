var nGrid1;
var rows = [
    [
        { data: "1656", style: "font-weight:bold;" },
        { data: "Over The Top" },
        { data: "Silvester" },
        { data: "2" },
        { data: "Procedimiento" },
        { data: "Administración y finanzas" },
        { data: "Tommy Lee Jones" }
    ],
    [
        { data: "1523", style: "font-weight:bold;" },
        { data: "Adobe Flash CS3" },
        { data: "FLASH 10" },
        { data: "2" },
        { data: "Norma" },
        { data: "Tecnología informática" },
        { data: "Francis Ford Copolla" }
    ],
    [
        { data: "1523", style: "font-weight:bold;" },
        { data: "Adobe Flash CS3" },
        { data: "FLASH 10" },
        { data: "2" },
        { data: "Norma" },
        { data: "Tecnología informática" },
        { data: "Francis Ford Copolla" }
    ],
    [
        { data: "1523", style: "font-weight:bold;" },
        { data: "Adobe Flash CS3" },
        { data: "FLASH 10" },
        { data: "2" },
        { data: "Norma" },
        { data: "Tecnología informática" },
        { data: "Francis Ford Copolla" }
    ],
    [
        { data: "1522", style: "font-weight:bold;" },
        { data: "Adobe Flash CS3" },
        { data: "FLASH 10" },
        { data: "2" },
        { data: "Norma" },
        { data: "Tecnología informática" },
        { data: "Francis Ford Copolla" }
    ],
    [
        { data: "1522", style: "font-weight:bold;" },
        { data: "Adobe Flash CS3" },
        { data: "FLASH 10" },
        { data: "2" },
        { data: "Norma" },
        { data: "Tecnología informática" },
        { data: "Francis Ford Copolla" }
    ],
    [
        { data: "1522", style: "font-weight:bold;" },
        { data: "Adobe Flash CS3" },
        { data: "FLASH 10" },
        { data: "2" },
        { data: "Norma" },
        { data: "Tecnología informática" },
        { data: "Francis Ford Copolla" }
    ],
    [
        { data: "1522", style: "font-weight:bold;" },
        { data: "Adobe Flash CS3" },
        { data: "FLASH 10" },
        { data: "2" },
        { data: "Norma" },
        { data: "Tecnología informática" },
        { data: "Francis Ford Copolla" }
    ],
    [
        { data: "1522", style: "font-weight:bold;" },
        { data: "Adobe Flash CS3" },
        { data: "FLASH 10" },
        { data: "2" },
        { data: "Norma" },
        { data: "Tecnología informática" },
        { data: "Francis Ford Copolla" }
    ],
    [
        { data: "1522", style: "font-weight:bold;" },
        { data: "Adobe Flash CS3" },
        { data: "FLASH 10" },
        { data: "2" },
        { data: "Norma" },
        { data: "Tecnología informática" },
        { data: "Francis Ford Copolla" }
    ]
];

var JSONTabla = {
		cols:[
			{title:"id", 		width: "76",	type:'number'},
			{title:"Titulo", 	width: "270",	type:'string'},
			{title:"Código", 	width: "100",	type:'string'},
			{title:"Revisión", 	width: "40",	type:'number'},
			{title:"Proceso", 	width: "100",	type:'string'},
			{title:"Tipo", 		width: "150",	type:'string'},
			{title:"Autor", 	width: "160",	type:'string'}
		],
		rows: rows
	};

nGrid1 = new Ness.Grid({
		id : "Nessy",
		titulo : "inicio",
		containerDIV : "grid1Div",
		dataTable : JSONTabla
	});

nGrid1.display();
sophantu = prompt("Nhap vao so phan tu")
let mang = new Array(sophantu);
for(let i = 0; i < sophantu; i++){
	mang[i] = prompt("Nhap phan tu thu " + (i + 1) + " ");
}
document.writeln("Mang ban dau ");
for(let i = 0; i < sophantu; i++){
		document.writeln(mang[i]);
	}
	mang.sort();
	document.writeln("<br>" +"Mang tang dan ");
	for(let i = 0; i < sophantu; i++){
		document.writeln(mang[i]);
	}

	mang.sort();
	mang.reverse();
	document.writeln("<br>" + "Mang giam dan ");
	for(let i = 0; i < sophantu; i++){
		document.writeln(mang[i]);
	}

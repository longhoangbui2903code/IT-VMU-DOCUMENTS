function tinh() {
	let chieudai = parseFloat(document.getElementById("txtchieudai").value);
	let chieurong = parseFloat(document.getElementById("txtchieurong").value);
	
	if (isNaN(chieudai) || isNaN(chieurong)) {
		document.getElementById("ketqua").innerHTML = "Vui lòng nhập số hợp lệ cho chiều dài và chiều rộng.";
		return;
	}
	
	let chuvi = (chieudai + chieurong) * 2;
	let dientich = chieudai * chieurong;
	document.getElementById("ketqua").innerHTML = 
		"Chu vi là: " + chuvi + "<br>" + "Diện tích là: " + dientich;
}
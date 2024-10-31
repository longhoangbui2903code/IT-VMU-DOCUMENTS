function check(a) {
	if((a % 4 == 0 && a % 100 != 0) || a % 400 == 0){
		alert("Nhuan");
	}else{
		alert("deo")
	}
}

function showDate() {
			const daysOfWeek = ["Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7"];
			const now = new Date();
			const day = daysOfWeek[now.getDay()];
			const date = now.getDate();
			const month = now.getMonth() + 1; // Tháng bắt đầu từ 0 nên cần +1
			const year = now.getFullYear();
			alert(`Hôm nay là ${day}, ngày ${date} tháng ${month} năm ${year}`);
		}
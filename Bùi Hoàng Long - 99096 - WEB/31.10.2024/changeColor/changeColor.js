function changeColor(){
	const currentColor = document.body.style.backgroundColor;
	document.body.style.backgroundColor = (currentColor === 'red') ? 'cyan' : 'red';
}
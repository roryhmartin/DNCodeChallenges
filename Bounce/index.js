console.log("Working........");

const canvas = document.querySelector("canvas");
const view = canvas.getContext("2d");

addEventListener("resize", onResize);

function onResize() {
    canvas.width = window.innerWidth;
    canvas.height = window.innerHeight;
    view.strokeStyle = "white";
    view.fillStyle = "white";
    view.fillRect(20, 20, 10, 10);
}

onResize();

class Ball {
    constructor() {
        this.x = Math.random() * canvas.width;
        this.y = Math.random() * canvas.height;
        this.dx = (Math.random() - 0.5) * 5; 
        this.dy = (Math.random() - 0.5) * 5;
        this.radius = 5;
    }
    update() {
        this.x += this.dx;
        this.y += this.dy;

        if(this.x > canvas.width || this.x < 0){
            this.dx = -this.dx;
        }
        if(this.y > canvas.height || this.y < 0){
            this.dy = -this.dy;
        }
    }
    draw() {
        this.update();
        // view.fillRect(this.x, this.y, 10, 10);
        // Make my balls round
        view.beginPath();
        view.arc(this.x, this.y, this.radius, 0, Math.PI * 2);
        view.fillStyle = "white";
        view.fill();
    }

    drawLineTo(otherBall) {
        const dx = otherBall.x - this.x;
        const dy = otherBall.y - this.y;
        const distance = Math.sqrt(dx * dx + dy * dy);
        const maxDistance = Math.sqrt(canvas.width * canvas.width + canvas.height * canvas.height);      
        const normalizedDistance = 1 - distance / maxDistance;

        view.beginPath();
        view.moveTo(this.x, this.y);
        view.lineTo(otherBall.x, otherBall.y);
        view.lineWidth = 2;
        // view.strokeStyle = `rgb(${Math.random() * 255}, ${Math.random() * 255}, ${Math.random() * 255}, ${normalizedDistance})`;
        view.strokeStyle = `rgb(255, 255, 255, ${normalizedDistance})`;
        view.stroke();
    }
}

const balls = [];
for(let i = 0; i < 25; i++){
    balls.push(new Ball());
}
const ball = new Ball(100, 100);
const ball2 = new Ball(50, 10);

ball.draw();

animate();

function animate() {
    view.clearRect(0, 0, canvas.width, canvas.height);

    for(let i = 0; i < balls.length; i++){
        balls[i].draw();

        for(let j = i + 1; j < balls.length; j++){
            balls[i].drawLineTo(balls[j]);
        }
    }

    requestAnimationFrame(animate);
}
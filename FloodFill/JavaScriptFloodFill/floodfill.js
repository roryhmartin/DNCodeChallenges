const canvas = document.getElementById('floodCanvas');
const canvasContext = canvas.getContext('2d');

const cellSize = 50;
const columns = canvas.width / cellSize;
const rows = canvas.height / cellSize;

// const fillImage = new Image();
// fillImage.src = 'images/placeholder-image-square.jpg';

const imageFiles = [
    'images/Cloud_Strife.png',
    'images/Lambda_logo.svg',
    'images/Quake_logo.svg',
    'images/unreal-tournament.svg',
    'images/commando.jpg',
    'images/mgs.png',
    'images/sc.png',
    'images/ad.jpg',
    'images/apam.jpg',
    'images/apls.jpg',
    'images/apmc.jpg',
    'images/apmd.jpg',
    'images/apsw.jpg',
];

// const preFilledCells = [
//     { x: 4, y: 4, imgIndex: 0 },
//     { x: 5, y: 5, imgIndex: 2 },
//     { x: 6, y: 6, imgIndex: 1 }
// ];

const fillImages = [];

imageFiles.forEach( (imagePath) => {
    const image = new Image();
    image.src = imagePath;
    image.onload = function() {
        fillImages.push(image);
        if (fillImages.length === imageFiles.length) {
            drawEmptyGrid();
        }
    };
});

function getRandomImage() {
    const ranodomImdex = Math.floor(Math.random() * fillImages.length);
    return fillImages[ranodomImdex];
}

// fillImage.src = 'images/Happy.gif';
// fillImage.onload = function () {
//     drawEmptyGrid();
// };

function drawEmptyGrid() {
    // preFilledCells.forEach( (cell) => {
    //     const img = fillImages[cell.imgIndex];
    //     if(img) {
    //         canvasContext.drawImage(
    //             img,
    //             cell.x * cellSize,
    //             cell.y * cellSize,
    //             cellSize,
    //             cellSize
    //         );
    //     }
    // });

    for (let x = 0; x < columns; x++) {
        for (let y = 0; y < rows; y++) {
            canvasContext.strokeRect(x * cellSize, y * cellSize, cellSize, cellSize);
        }
    }
}

function floodFill(startCol, startRow) {
    let cellsToCheck = [];
    cellsToCheck.push({x: startCol, y: startRow});
    let filledCells = [];

    function fillOneCell() {
        if (cellsToCheck.length === 0) {
            return;
        }

        let currentCell = cellsToCheck.pop();

        let alreadyFilled = false;
        for (let cell of filledCells) {
            if (cell.x === currentCell.x && cell.y === currentCell.y) {
                alreadyFilled = true;
            }
        }

        let isOutsideGrid = currentCell.x < 0 ||
            currentCell.y < 0 ||
            currentCell.x >= columns ||
            currentCell.y >= rows;

        if (alreadyFilled || isOutsideGrid) {
            fillOneCell();
            return;
        }``

        filledCells.push(currentCell);

        const randomImage = getRandomImage();

        canvasContext.drawImage(
            randomImage,
            currentCell.x * cellSize,
            currentCell.y * cellSize,
            cellSize,
            cellSize
        );

        cellsToCheck.push({x: currentCell.x + 1, y: currentCell.y});
        cellsToCheck.push({x: currentCell.x - 1, y: currentCell.y});
        cellsToCheck.push({x: currentCell.x, y: currentCell.y + 1});
        cellsToCheck.push({x: currentCell.x, y: currentCell.y - 1});

        setTimeout(fillOneCell, 100);
    }

    fillOneCell();
}
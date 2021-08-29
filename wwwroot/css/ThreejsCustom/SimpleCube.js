window.onload = function (idCanvas) {


    const canvas = document.getElementById(idCanvas);


    const width = window.innerWidth - 80;
    const height = window.innerHeight - 80;

    canvas.setAttribute('width', width);
    canvas.setAttribute('height', height);
    var render = new THREE.WebGLRenderer({ canvas: canvas });
    render.setSize(width, height);
    render.setClearColor(0x808080);

    var scene = new THREE.Scene();

    var camera = new THREE.PerspectiveCamera(45, width / height, 0.1, 15000);
    camera.position.set(1000, 0, 2500);

    var light = new THREE.AmbientLight(0xffffff);
    scene.add(light);

    const geometry = new THREE.BoxGeometry(100, 100, 100);
    const material = new THREE.MeshBasicMaterial({ color: 0x345678 });


    let arrayCube = [];
    for (let i = 0; i < 50000; i++) {

        var cube = new THREE.Mesh(geometry, material);
        cube.position.set(-1000 + i * 10, (Math.random() * (1000 - -1000) + -1000),
            (Math.random() * (100 - -50) + -50));
        arrayCube.push(cube);
        scene.add(cube);
    }

    function renderAnimation() {
        requestAnimationFrame(renderAnimation);
        for (let index = 0; index < arrayCube.length; index++) {
            arrayCube[index].rotation.x += 0.02;
            arrayCube[index].rotation.y += 0.02;
        }
        render.render(scene, camera);
    }
    renderAnimation();
};
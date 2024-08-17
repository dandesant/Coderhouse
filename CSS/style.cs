* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  text-decoration: none;
  color: inherit;
}

a {
  text-decoration: none;
  color: inherit;
}

h1 {
  font-family: "Montserrat", sans-serif;
  font-size: 35px;
  font-weight: 900;
  font-style: normal;
}

h2 {
  font-family: "Montserrat", sans-serif;
  font-size: 30px;
  font-weight: 900;
}

h3 {
  font-family: "Montserrat", sans-serif;
  font-size: 16px;
  font-weight: 700;
}

footer {
  background-color: rgb(246, 246, 246);
  padding: 20px 20px 50px 20px;
}
footer ul li {
  display: flex;
  flex-direction: column;
}

.footer {
  padding-left: 30px;
  font-family: "Montserrat", sans-serif;
  font-size: 12px;
  font-weight: 600;
}

.footer p {
  width: 250px;
}

.footer ul {
  width: auto;
}

footer section {
  display: flex;
  flex-wrap: wrap;
}

p {
  font-family: "Montserrat", sans-serif;
  font-size: 13px;
  font-weight: 500;
}

.banner {
  width: 100%;
  height: auto;
}

.contenedor {
  margin: 20px 50px 20px 50px;
}

.button-standard {
  background-color: rgb(230, 97, 60);
  color: white;
  border: none;
  padding: 5px 30px;
  border-radius: 5px;
  width: 120px;
  font-weight: 600;
}

header {
  font-family: "Montserrat", sans-serif;
  font-optical-sizing: auto;
  font-weight: 500;
  font-style: normal;
  backdrop-filter: blur(40px);
}

.text-nav {
  --bs-text-opacity: .8;
}

.banner-img {
  width: 100%;
  height: auto;
  object-fit: cover;
}

.banner-index {
  position: static;
  top: 0;
  left: 0;
}

.tigre {
  width: 100%;
  height: auto;
}

.grid {
  display: grid;
  grid-template-columns: 25% 75%;
  align-content: center;
}

.bloquenov {
  width: 440px;
  height: 250px;
  padding: 10px;
  display: flex;
  flex-direction: row;
  font-family: "Montserrat", sans-serif;
  font-size: 13px;
  font-weight: 500;
  font-style: normal;
}

.bloquenov p {
  font-size: 12px;
}

.bloquenov img {
  width: auto;
  height: 100%;
}

.img-nov {
  object-fit: cover;
}

.Novedades {
  display: flex;
  flex-direction: column;
  margin-top: 10px;
}

.wrap {
  display: flex;
  flex-flow: row wrap;
  width: auto;
  justify-content: center;
}

.galeria {
  display: flex;
  flex-flow: row nowrap;
  margin-bottom: 30px;
  height: 300px;
}

.preguntas {
  padding: 30px;
  width: 300px;
  height: 300px;
  font-family: "Montserrat", sans-serif;
  font-size: 14px;
  font-weight: 500;
  font-style: normal;
}

.transparencia {
  display: flex;
  justify-content: center;
  align-items: center;
  margin-bottom: 40px;
}

.transparencia img {
  width: 500px;
  height: auto;
  object-fit: cover;
}

.div-animales {
  text-align: center;
  margin: 15px;
}

.div-animales img {
  width: 200px;
  height: auto;
  padding-bottom: 10px;
}

.div-atracciones {
  text-align: center;
  margin: 15px;
}

.div-atracciones img {
  width: 250px;
  margin-bottom: 10px;
}

.listapaquetes {
  font-family: "Montserrat", sans-serif;
  font-size: 14px;
  font-weight: 500;
  margin-left: 70px;
  margin-top: 20px;
  margin-bottom: 20px;
}

.grid-paquetes {
  display: grid;
  grid-template-columns: 20% 80%;
}

.menu-paquetes {
  margin-top: 70px;
  font-family: "Montserrat", sans-serif;
  font-size: 19px;
  font-weight: 700;
}

.selected-menu {
  background-color: rgb(230, 97, 60);
  width: 160px;
  padding: 5px 40px 5px 30px;
  border-radius: 50px;
  color: white;
  list-style: none;
}

.boton-paquetes {
  background-color: rgb(230, 97, 60);
  width: 160px;
  padding: 5px 30px 5px 30px;
  border-radius: 50px;
  color: white;
  border: 0;
  font-family: "Montserrat", sans-serif;
  font-size: 16px;
  font-weight: 700;
  display: none;
}

@media screen and (max-width: 835px) {
  .wrap {
    display: grid;
    grid-template-columns: 33% 33% 33%;
  }
  .banner {
    height: 400px;
    object-fit: cover;
  }
  .banner img {
    width: 100%;
    height: 100%;
    object-fit: cover;
  }
  .footer {
    width: 150px;
    height: auto;
    padding-left: 20px;
  }
  .footer p {
    width: 120px;
  }
  .footer ul {
    padding: 0px;
    width: auto;
  }
  footer {
    padding: 30px;
  }
  /* index */
  .banner-img {
    width: 100%;
    height: 100%;
    object-fit: cover;
  }
  .banner-index {
    height: 500px;
    width: auto;
  }
  .contenedor {
    margin: 20px 20px 20px 20px;
  }
  .div-tigre {
    display: none;
  }
  .bloquenov {
    flex-direction: column;
    width: 100%;
    height: auto;
  }
  .bloquenov img {
    width: 100%;
    height: 300px;
    object-fit: cover;
  }
  .bloquenov p {
    font-size: 13px;
  }
  .img-nov {
    justify-content: center;
    align-items: center;
  }
  .grid {
    display: grid;
    grid-template-columns: 100%;
    margin-bottom: 30px;
  }
  .galeria {
    height: 300px;
  }
  .preguntas {
    width: 100%;
    height: auto;
  }
  .transparencia img {
    width: 500px;
    height: auto;
    object-fit: cover;
    margin-right: 20px;
  }
  .transparencia {
    width: 100%;
    margin-left: 20px;
  }
  /* animales */
  .div-animales img {
    width: 250px;
  }
  /* paquetes */
  .menu-paquetes {
    display: none;
  }
  .grid-paquetes {
    grid-template-columns: 100%;
  }
  .boton-paquetes {
    display: block;
    margin-bottom: 20px;
  }
}
@media screen and (max-width: 431px) {
  .wrap {
    display: grid;
    grid-template-columns: 50% 50%;
  }
  footer ul {
    display: none;
  }
  footer {
    padding: 30px;
  }
  /* index */
  .bloquenov img {
    width: 170px;
    height: auto;
  }
  .preguntas {
    padding: 20px;
    width: 180px;
    height: auto;
  }
  .transparencia img {
    width: 300px;
  }
  /* animales */
  .div-animales img {
    width: 150px;
    height: auto;
  }
  /* atracciones */
  .div-atracciones img {
    width: 150px;
  }
  /* paquetes */
  .listapaquetes {
    font-family: "Montserrat", sans-serif;
    font-size: 14px;
    font-weight: 500;
    margin-left: 10px;
    margin-top: 20px;
    margin-bottom: 20px;
  }
}

/*# sourceMappingURL=style.cs.map */

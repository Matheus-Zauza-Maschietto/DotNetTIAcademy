<script>
  export default{
    name: "app",
    data(){
      return{
        controllData:{
          vendedor: false
        }
      }
    }
  }
</script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
<template>
  <div id="app">

    <div class="header">
      <div class="dropdown">
        <button class="dropbtn">Vendedores</button>
        <div class="dropdown-content">
          <router-link to="/vendedor/listar">Listar vendedores</router-link>
          <router-link to="/vendedor/cadastrar">Cadastrar vendedor</router-link>
        </div>
      </div>
      <div class="dropdown">
        <button class="dropbtn">Clientes</button>
        <div class="dropdown-content">
          <router-link to="/cliente/listar">Listar clientes</router-link>
          <router-link to="/cliente/cadastrar">Cadastrar clientes</router-link>
        </div>
      </div>
      <div class="dropdown">
        <button class="dropbtn">Serviços</button>
        <div class="dropdown-content">
          <router-link to="/servico/listar">Listar serviços</router-link>
          <router-link to="/servico/cadastrar">Cadastrar serviço</router-link>
        </div>
      </div>
      <div class="dropdown">
        <button class="dropbtn">Pedidos</button>
        <div class="dropdown-content">
          <router-link to="/pedido/listar">Listar itens pedido</router-link>
          <router-link to="/pedido/cadastrar">Cadastrar item pedido</router-link>
        </div>
      </div>
    </div>
    <div class="body">
      <router-view/>
    </div>
    
  </div>

</template>

<style scoped>
body {
  font-family: Arial, Helvetica, sans-serif;
}
.body{
  width: 100vw;
  display: flex;
  justify-content: center;
}
.header{
  width: 100vw;
  display: flex;
  justify-content: center;
  background-color: #4CAF50;
}

/* Style The Dropdown Button */
.dropbtn {
  background-color: #4CAF50;
  color: white;
  padding: 16px;
  font-size: 16px;
  border: none;
  cursor: pointer;
}

/* The container <div> - needed to position the dropdown content */
.dropdown {
  position: relative;
  display: inline-block;
}

/* Dropdown Content (Hidden by Default) */
.dropdown-content {
  display: none;
  position: absolute;
  background-color: #f9f9f9;
  min-width: 160px;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
}

/* Links inside the dropdown */
.dropdown-content a {
  color: black;
  padding: 12px 16px;
  text-decoration: none;
  display: block;
}

/* Change color of dropdown links on hover */
.dropdown-content a:hover {background-color: #f1f1f1}

/* Show the dropdown menu on hover */
.dropdown:hover .dropdown-content {
  display: block;
}

/* Change the background color of the dropdown button when the dropdown content is shown */
.dropdown:hover .dropbtn {
  background-color: #3e8e41;
}
</style>

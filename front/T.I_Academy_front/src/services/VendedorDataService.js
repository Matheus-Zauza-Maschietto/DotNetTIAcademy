import http from "../http-common.js"

class VendedorDataService{
    listar(){
        return http.get('/listar')
    }
}

export default new VendedorDataService()
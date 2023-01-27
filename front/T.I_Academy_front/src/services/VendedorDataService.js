import http from "../http-common.js"

class VendedorDataService{
    listar(){
        return http.get('/vendedor')
    }
}

export default new VendedorDataService()
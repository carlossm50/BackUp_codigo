
import './App.css';
import SearchBar from "./component/search";
import '../node_modules/bootstrap/dist/css/bootstrap.min.css'
import '../node_modules/bootstrap/dist/js/bootstrap.min.js'
import "bootstrap-icons/font/bootstrap-icons.css";
import 'react-toastify/dist/ReactToastify.css';


function App() {
  return (
    <div className="container-fluid pt-5 bg-light" >
      <SearchBar />
      
        <div className="bg-dark text-secondary px-4 py-5 text-center">
          <div className="py-5">
            <h1 className="display-5 fw-bold text-white">Carlos Severino</h1>
            <div className="col-lg-6 mx-auto">
              <p className="fs-5 mb-4"><i className="bi bi-whatsapp" ></i> <span> 829-264-3239</span></p>
              <div className="d-grid gap-2 d-sm-flex justify-content-sm-center">
                <button type="button" className="btn btn-outline-info btn-lg px-4 me-sm-3 fw-bold"><i className="bi bi-facebook" ></i></button>
                <button type="button" className="btn btn-outline-light btn-lg px-4"><i className="bi bi-twitter" ></i></button>
              </div>
            </div>
          </div>
        </div>
      
    </div>
  );
}

export default App;

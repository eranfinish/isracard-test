import logo from './logo.svg';
import './App.css';

function App() {

  return (
    <div>
    <div className="App">
    <div className="menu" onClick={""}>
        <div className="menu-line"></div>
        <div className="menu-line"></div>
        <div className="menu-line"></div>

    </div>
    <div className="cards">
      <ui >
        <li>Report A</li>
        <li>Report B</li>
        <li>Report C</li>
        <li>Report D</li>
      </ui>
    </div>
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
    </div>
  );
}

export default App;

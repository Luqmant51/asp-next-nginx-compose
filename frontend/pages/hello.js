import Head from 'next/head';
import styles from '../styles/Home.module.css';

export default function Home(props) {
  return (
    <div className={styles.container}>
      <Head>
        <title>Create Next App</title>
        <link rel="icon" href="/favicon.ico" />
      </Head>

      <main>
        <h1 className={styles.title}>
          <a href="https://nextjs.org">{props.message}</a>
        </h1>
      </main>
    </div>
  );
}

export const getServerSideProps = async (context) => {
  const res = await fetch('http://backend:8080/api/hello');
  console.log(res);
  const data = await res.text();
  console.log("data");
  console.log(data);
  return { props: { message: data } };
};
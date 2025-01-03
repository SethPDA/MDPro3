using System.Collections.Generic;
using UnityEngine;

public class ParticleSwirl_twist : MonoBehaviour
{
	private class ParticleInfo
	{
		public float particle_life;

		public float particle_start_pos;

		public float particle_range;

		public float particle_rotation_x;

		public float particle_rotation_y;

		public float particle_rotation_z;

		public float particle_twist_rotation;
	}

	private ParticleSystem pe;

	private ParticleSystem.Particle[] particle;

	public int particle_total;

	public int start_particle_total;

	public float particle_appearance_interval;

	public float particle_appear_radius;

	public float particle_appear_radius_max;

	public float particle_thick;

	public float appear_spread_time;

	public float appear_spread_speed;

	public bool particle_3D_rotation;

	public float converge_radius_spread_time;

	public float converge_radius_spread_speed;

	public float converge_radius_max;

	public float anlgle_speed;

	public float anlgle_accel;

	public float anlgle_max_speed;

	public float circle_decrease_speed;

	private int particle_num;

	private int numParticlesAlive;

	private float base_particle_angle;

	private float particule_appearance_time;

	private float converge_radius;

	private float base_particle_twist_angle;

	private float time;

	private int cut_num;

	private int cut_total;

	private List<ParticleInfo> particleInfos;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void particle_ini()
	{
	}

	private void particle_move()
	{
	}
}
